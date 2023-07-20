﻿using System.Text.Json;
using LLServer.Common;
using LLServer.Database;
using LLServer.Database.Models;
using LLServer.Mappers;
using LLServer.Models.Requests;
using LLServer.Models.Responses;
using LLServer.Models.UserData;
using MediatR;
using Microsoft.EntityFrameworkCore;

// ReSharper disable UnusedType.Global
namespace LLServer.Handlers;

public record InitializeUserDataCommand(RequestBase request) : IRequest<ResponseContainer>;

public class InitializeUserDataCommandHandler : IRequestHandler<InitializeUserDataCommand, ResponseContainer>
{
    private readonly ApplicationDbContext dbContext;
    private readonly ILogger<InitializeUserDataCommandHandler> logger;

    public InitializeUserDataCommandHandler(ApplicationDbContext dbContext, ILogger<InitializeUserDataCommandHandler> logger)
    {
        this.dbContext = dbContext;
        this.logger = logger;
    }

    public async Task<ResponseContainer> Handle(InitializeUserDataCommand command, CancellationToken cancellationToken)
    {
        if (command.request.Param is null)
        {
            return StaticResponses.BadRequestResponse;
        }
        
        var paramJson = command.request.Param.Value.GetRawText();

        //get session
        Session? session = await dbContext.Sessions
            .Include(s => s.User)
            .Include(s => s.User.UserData)
            .Include(s => s.User.UserDataAqours)
            .Include(s => s.User.UserDataSaintSnow)

            .Include(s => s.User.Members)
            .Include(s => s.User.MemberCards)

            .Include(s => s.User.TravelData)
            .Include(s => s.User.TravelPamphlets)
            .Include(s => s.User.TravelHistory)
            .Include(s => s.User.TravelHistoryAqours)
            .Include(s => s.User.TravelHistorySaintSnow)
            
            .Include(s => s.User.AchievementRecordBooks)
            
            .FirstOrDefaultAsync(s => 
                s.SessionId == command.request.SessionKey, 
            cancellationToken);

        if (session is null)
        {
            return StaticResponses.BadRequestResponse;
        }
        
        //get the initialize command
        InitializeUserData? initializeUserData = JsonSerializer.Deserialize<InitializeUserData>(paramJson);
        if (initializeUserData is null)
        {
            return StaticResponses.BadRequestResponse;
        }
        
        //write to db
        PersistentUserDataContainer container = new(dbContext, session.User);

        container.Initialize(initializeUserData);
        session.User.Initialized = true;
        
        await dbContext.SaveChangesAsync(cancellationToken);

        //response
        UserDataResponseMapper mapper = new();

        return new ResponseContainer
        {
            Result = 200,
            Response = mapper.FromPersistentUserData(container)
        };
    }
}