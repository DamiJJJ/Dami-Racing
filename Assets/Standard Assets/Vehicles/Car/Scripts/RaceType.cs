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
                // Gold
                if(SaveScript.RaceTimeMinutes == GoldMinutes && SaveScript.RaceTimeSeconds <= GoldSeconds)
                {
                    SaveScript.Gold = true;
                }
                // Silver
                if(!SaveScript.Gold)
                {
                    if(SaveScript.RaceTimeMinutes == SilverMinutes && SaveScript.RaceTimeSeconds <= SilverSeconds)
                    {
                        SaveScript.Silver = true;
                    }
                }
                // Bronze
                if(!SaveScript.Gold && !SaveScript.Silver)
                {
                    if(SaveScript.RaceTimeMinutes == BronzeMinutes && SaveScript.RaceTimeSeconds <= BronzeSeconds)
                    {
                        SaveScript.Bronze = true;
                    }
                }

                // Fail
                else if(!SaveScript.Gold && !SaveScript.Silver && !SaveScript.Bronze)
                {
                    SaveScript.Fail = true;
                }
            }
        }
    }
}
