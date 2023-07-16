﻿using System.Text.Json.Serialization;
// ReSharper disable UnusedAutoPropertyAccessor.Global
namespace LLServer.Models.UserData;

public class LiveData
{
    [JsonPropertyName("m_live_id")]
    public int LiveId { get; set; } 

    [JsonPropertyName("select_count")]
    public int SelectCount { get; set; } 

    [JsonPropertyName("unlocked")]
    public bool Unlocked { get; set; } 

    [JsonPropertyName("new")]
    public bool New { get; set; } 

    [JsonPropertyName("full_combo")]
    public bool FullCombo { get; set; } 

    [JsonPropertyName("total_hi_score")]
    public int TotalHiScore { get; set; } 

    [JsonPropertyName("technical_hi_score")]
    public int TechnicalHiScore { get; set; } 

    [JsonPropertyName("technical_hi_rate")]
    public int TechnicalHiRate { get; set; } 

    [JsonPropertyName("coop_total_hi_score_2")]
    public int CoopTotalHiScore2 { get; set; } 

    [JsonPropertyName("coop_total_hi_score_3")]
    public int CoopTotalHiScore3 { get; set; }

    [JsonPropertyName("player_count_1")]
    public int PlayerCount1 { get; set; }

    [JsonPropertyName("player_count_2")]
    public int PlayerCount2 { get; set; } 

    [JsonPropertyName("player_count_3")]
    public int PlayerCount3 { get; set; } 

    [JsonPropertyName("rank_count_0")]
    public int RankCount0 { get; set; } 

    [JsonPropertyName("rank_count_1")]
    public int RankCount1 { get; set; } 

    [JsonPropertyName("rank_count_2")]
    public int RankCount2 { get; set; } 

    [JsonPropertyName("rank_count_3")]
    public int RankCount3 { get; set; } 

    [JsonPropertyName("rank_count_4")]
    public int RankCount4 { get; set; } 

    [JsonPropertyName("rank_count_5")]
    public int RankCount5 { get; set; } 

    [JsonPropertyName("rank_count_6")]
    public int RankCount6 { get; set; } 

    [JsonPropertyName("trophy_count_gold")]
    public int TrophyCountGold { get; set; } 

    [JsonPropertyName("trophy_count_silver")]
    public int TrophyCountSilver { get; set; } 

    [JsonPropertyName("trophy_count_bronze")]
    public int TrophyCountBronze { get; set; } 

    [JsonPropertyName("finale_count")]
    public int FinaleCount { get; set; } 

    [JsonPropertyName("technical_rank")]
    public int TechnicalRank { get; set; } 
    
    [JsonIgnore] public static int[] LiveIds = new[]
    {
        10,
        20,
        30,
        40,
        50,
        60,
        70,
        80,
        90,
        100,
        110,
        120,
        130,
        140,
        150,
        160,
        170,
        180,
        190,
        200,
        210,
        220,
        230,
        240,
        250,
        260,
        270,
        280,
        290,
        300,
        310,
        320,
        330,
        340,
        350,
        360,
        370,
        380,
        390,
        400,
        410,
        420,
        430,
        440,
        450,
        460,
        470,
        480,
        490,
        500,
        510,
        520,
        530,
        540,
        550,
        560,
        570,
        580,
        590,
        600,
        610,
        620,
        630,
        640,
        650,
        660,
        670,
        680,
        690,
        700,
        710,
        720,
        6010,
        6020,
        6030,
        6040,
        6050,
        6060,
        6070,
        6080,
        6090,
        6100,
        6110,
        6120,
        6130,
        6140,
        6150,
        6160,
        6170,
        6180,
        6190,
        6200,
        6210,
        6220,
        6230,
        6240,
        6250,
        6260,
        6270,
        6280,
        6290,
        6300,
        6310,
        6320,
        6330,
        6340,
        6350,
        6360,
        6370,
        6380,
        6390,
        6400,
        6410,
        6420,
        6430,
        6440,
        6450,
        6460,
        6470,
        6480,
        6490,
        6500,
        6510,
        6520,
        6530,
        6540,
        6550,
        6560,
        6570,
        6580,
        6590,
        6600,
        6610,
        6620,
        6630,
        6640,
        6650,
        6660,
        6670,
        6680,
        6690,
        6700,
        6710,
        6720,
        1010,
        1020,
        1030,
        1040,
        1050,
        1060,
        1070,
        1080,
        1090,
        1100,
        1110,
        1120,
        1130,
        1150,
        1160,
        1170,
        1180,
        1190,
        1200,
        1210,
        1220,
        1230,
        1240,
        1250,
        1260,
        1270,
        1280,
        1290,
        1300,
        1310,
        1320,
        1330,
        1340,
        1350,
        1360,
        1370,
        1380,
        1390,
        1430,
        1440,
        1450,
        1460,
        1470,
        1480,
        1490,
        1500,
        1510,
        1520,
        1530,
        1540,
        1550,
        1900,
        1910,
        1920,
        1930,
        1940,
        7010,
        7020,
        7030,
        7040,
        7050,
        7060,
        7070,
        7080,
        7090,
        7100,
        7110,
        7120,
        7130,
        7150,
        7160,
        7170,
        7180,
        7190,
        7200,
        7210,
        7220,
        7230,
        7240,
        7250,
        7260,
        7270,
        7280,
        7290,
        7300,
        7310,
        7320,
        7330,
        7340,
        7350,
        7360,
        7370,
        7380,
        7390,
        7430,
        7440,
        7450,
        7460,
        7470,
        7480,
        7490,
        7500,
        7510,
        7520,
        7530,
        7540,
        7550,
        7900,
        7910,
        7920,
        7930,
        7940,
        8010,
        8020,
        8030,
        8040,
        8050,
        8060,
        8070,
        8090,
        8100,
        8120,
        8160,
        8170,
        8180,
        8190,
        8200,
        8210,
        8220,
        8230,
        8240,
        8250,
        8260,
        8270,
        8290,
        8300,
        8310,
        9010,
        9020,
        9030,
        9999,
    };
}