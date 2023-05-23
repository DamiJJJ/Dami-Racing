using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class OptionsMenuScript : MonoBehaviour
{
    public TextMeshProUGUI Mode;
    public TextMeshProUGUI LapCount;
    public TextMeshProUGUI OpponentCount;

    public int TimeTrialSceneNumber;
    public int RaceTrackSceneNumber;

    private bool TimeTrial = true;
    private int CurrentLapCount = 1;
    private int CurrentOpponentCount = 1;

    public void ModeNext()
    {
        if(TimeTrial)
        {
            Mode.text = "RACE";
            TimeTrial = false;
        }
    }

    public void ModeBack()
    {
        if(!TimeTrial)
        {
            Mode.text = "TIME TRIAL";
            TimeTrial = true;
        }
    }

    public void LapCountNext()
    {
        if(CurrentLapCount < 12)
        {
            CurrentLapCount++;
            LapCount.text = CurrentLapCount + " LAPS";
            UniversalSave.LapCounts = CurrentLapCount;
        }
    }

    public void LapCountBack()
    {
        if(CurrentLapCount > 2)
        {
            CurrentLapCount--;
            LapCount.text = CurrentLapCount + " LAPS";
            UniversalSave.LapCounts = CurrentLapCount;
        }
        else if(CurrentLapCount == 2)
        {
            CurrentLapCount--;
            LapCount.text = CurrentLapCount + " LAP";
            UniversalSave.LapCounts = CurrentLapCount;
        }
    }

    public void OpponentNext()
    {
        if(CurrentOpponentCount < 7)
        {
            CurrentOpponentCount++;
            OpponentCount.text = CurrentOpponentCount + " OPPONENTS";
        }
    }
    public void OpponentBack()
    {
        if(CurrentOpponentCount > 2)
        {
            CurrentOpponentCount--;
            OpponentCount.text = CurrentOpponentCount + " OPPONENTS";
        }
        else if(CurrentOpponentCount == 2)
        {
            CurrentOpponentCount--;
            OpponentCount.text = CurrentOpponentCount + " OPPONENT";
        }
    }

    public void BeginRace()
    {
        if(TimeTrial)
        {
            SceneManager.LoadScene(TimeTrialSceneNumber);
        }
        if(!TimeTrial)
        {
            SceneManager.LoadScene(RaceTrackSceneNumber);
        }
    }
}
