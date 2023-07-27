﻿using LLServer.Common;
using LLServer.Database;
using LLServer.Mappers;
using LLServer.Models.Requests;
using LLServer.Models.Responses;
using LLServer.Models.UserData;
using MediatR;
using Microsoft.EntityFrameworkCore;

// ReSharper disable UnusedType.Global
namespace LLServer.Handlers;

public record GetUserDataQuery(RequestBase request) : IRequest<ResponseContainer>;

public class GetUserDataQueryHandler : IRequestHandler<GetUserDataQuery, ResponseContainer>
{
    private readonly ApplicationDbContext dbContext;
    private readonly ILogger<GetUserDataQueryHandler> logger;

    public GetUserDataQueryHandler(ApplicationDbContext dbContext, ILogger<GetUserDataQueryHandler> logger)
    {
        this.dbContext = dbContext;
        this.logger = logger;
    }

    public async Task<ResponseContainer> Handle(GetUserDataQuery query, CancellationToken cancellationToken)
    {
        //get session
        //todo: abstract this into PersistentUserDataContainer completely
        var session = await dbContext.Sessions
            .AsSplitQuery()
            .Where(s => s.SessionId == query.request.SessionKey)
            .Select(s => new
            {
                Session = s,
                User = s.User,
                UserData = s.User.UserData,
                UserDataAqours = s.User.UserDataAqours,
                UserDataSaintSnow = s.User.UserDataSaintSnow,
                Members = s.User.Members,
                MemberCards = s.User.MemberCards,
                LiveDatas = s.User.LiveDatas,
                TravelData = s.User.TravelData,
                TravelPamphlets = s.User.TravelPamphlets,
                TravelHistory = s.User.TravelHistory,
                TravelHistoryAqours = s.User.TravelHistoryAqours,
                TravelHistorySaintSnow = s.User.TravelHistorySaintSnow,
                Achievements = s.User.Achievements,
                YellAchievements = s.User.YellAchievements,
                AchievementRecordBooks = s.User.AchievementRecordBooks,
                Items = s.User.Items,
                SpecialItems = s.User.SpecialItems,
                NamePlates = s.User.NamePlates,
                Badges = s.User.Badges,
            }).FirstOrDefaultAsync(cancellationToken);

        if (session is null)
        {
            return StaticResponses.BadRequestResponse;
        }

        //get persistent userdata container
        PersistentUserDataContainer container = new(dbContext, session.User);

        //response
        UserDataResponseMapper mapper = new();
        UserDataResponse response = mapper.FromPersistentUserData(container);

        //todo: get rid of this
        //stupid hack to prevent the name entry popup and tutorials from showing up
        response.Flags = response.Flags.Replace("0", "1");

        return new ResponseContainer
        {
            Result = 200,
            Response = response
        };
    }
}