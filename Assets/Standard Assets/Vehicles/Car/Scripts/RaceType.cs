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
}
