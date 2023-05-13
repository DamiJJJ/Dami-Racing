using UnityEngine;

public class RaceType : MonoBehaviour
{
    public bool TimeTrial = true;
    public float GoldMinutes;
    public float GoldSeconds;
    public float SilverMinutes;
    public float SilverSeconds;
    public float BronzeMinutes;
    public float BronzeSeconds;

    private void Start()
    {
        if(TimeTrial)
        {
            SaveScript.TimeTrialMinG = GoldMinutes;
            SaveScript.TimeTrialSecondsG = GoldSeconds;
            SaveScript.TimeTrialMinS = SilverMinutes;
            SaveScript.TimeTrialSecondsS = SilverSeconds;
            SaveScript.TimeTrialMinB = BronzeMinutes;
            SaveScript.TimeTrialSecondsB = BronzeSeconds;
        }
    }

    private void Update()
    {
        if(SaveScript.RaceOver)
        {
            if(TimeTrial)
            {
                if((SaveScript.RaceTimeSeconds + SaveScript.PenaltySeconds) > 59)
                {
                    SaveScript.PenaltySeconds = (SaveScript.RaceTimeSeconds + SaveScript.PenaltySeconds) - 59;
                    SaveScript.RaceTimeMinutes++;
                    SaveScript.RaceTimeSeconds = 0 + SaveScript.PenaltySeconds;
                }
                // Gold
                if(SaveScript.RaceTimeMinutes < GoldMinutes)
                {
                    SaveScript.Gold = true;
                }
                if(SaveScript.RaceTimeMinutes == GoldMinutes && (SaveScript.RaceTimeSeconds + SaveScript.PenaltySeconds) <= GoldSeconds)
                {
                    SaveScript.Gold = true;
                }
                // Silver
                if(!SaveScript.Gold)
                {
                    if(SaveScript.RaceTimeMinutes < SilverMinutes)
                    {
                        SaveScript.Silver = true;
                    }
                    if(SaveScript.RaceTimeMinutes == SilverMinutes && (SaveScript.RaceTimeSeconds + SaveScript.PenaltySeconds) <= SilverSeconds)
                    {
                        SaveScript.Silver = true;
                    }
                }
                // Bronze
                if(!SaveScript.Gold && !SaveScript.Silver)
                {
                    if(SaveScript.RaceTimeMinutes < BronzeMinutes)
                    {
                        SaveScript.Bronze = true;
                    }
                    if(SaveScript.RaceTimeMinutes == BronzeMinutes && (SaveScript.RaceTimeSeconds + SaveScript.PenaltySeconds) <= BronzeSeconds)
                    {
                        SaveScript.Bronze = true;
                    }
                }
                // Fail
                if(!SaveScript.Gold && !SaveScript.Silver && !SaveScript.Bronze)
                {
                    SaveScript.Fail = true;
                }
            }
        }
    }
}
