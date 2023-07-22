﻿using System.Text.Json.Serialization;
using LLServer.Models.UserData;

namespace LLServer.Models.Requests;

/*
{
    "param": {
        "member_yell": [
        {
            "character_id": 4,
            "yell_achieve_rank": 7
        }
        ],
        "small_reward_count": 6,
        "yell_achievements": []
    },
}*/

public class AchievementYellParam
{
    [JsonPropertyName("member_yell")]
    public MemberYellAchievement[] MemberYellAchievements { get; set; } = Array.Empty<MemberYellAchievement>();
    
    [JsonPropertyName("small_reward_count")]
    public int SmallRewardCount { get; set; }
    
    [JsonPropertyName("yell_achievements")]
    public YellAchievement[] YellAchievements { get; set; } = Array.Empty<YellAchievement>();
}

public class MemberYellAchievement
{
    [JsonPropertyName("character_id")]
    public int CharacterId { get; set; }
    
    [JsonPropertyName("yell_achieve_rank")]
    public int AchieveRank { get; set; }
}