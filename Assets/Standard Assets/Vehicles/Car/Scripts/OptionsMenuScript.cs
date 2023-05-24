using  System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class OptionsMenuScript : MonoBehaviour
{
    public TextMeshProUGUI Mode;
    public TextMeshProUGUI LapCount;
    public TextMeshProUGUI OpponentCount;
    public GameObject LoadScreen;
    public GameObject OpponentsOn;
    public GameObject LapsOn;

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
            OpponentsOn.SetActive(true);
            LapsOn.SetActive(false);
        }
    }

    public void ModeBack()
    {
        if(!TimeTrial)
        {
            Mode.text = "TIME TRIAL";
            TimeTrial = true;
            OpponentsOn.SetActive(false);
            LapsOn.SetActive(true);
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
            UniversalSave.OpponentsCount = CurrentOpponentCount;
        }
    }
    public void OpponentBack()
    {
        if(CurrentOpponentCount > 2)
        {
            CurrentOpponentCount--;
            OpponentCount.text = CurrentOpponentCount + " OPPONENTS";
            UniversalSave.OpponentsCount = CurrentOpponentCount;
        }
        else if(CurrentOpponentCount == 2)
        {
            CurrentOpponentCount--;
            OpponentCount.text = CurrentOpponentCount + " OPPONENT";
            UniversalSave.OpponentsCount = CurrentOpponentCount;
        }
    }

    public void BeginRace()
    {
        StartCoroutine(WaitToLoad());
    }

    IEnumerator WaitToLoad()
    {
        yield return new WaitForSeconds(0.3f);
        LoadScreen.SetActive(true);
        if(TimeTrial)
        {
            UniversalSave.LapCounts = 1;
            UniversalSave.OpponentsCount = 0;
            SceneManager.LoadScene(TimeTrialSceneNumber);
        }
        if(!TimeTrial)
        {
            UniversalSave.LapCounts = CurrentLapCount;
            SceneManager.LoadScene(RaceTrackSceneNumber);
            UniversalSave.OpponentsCount = CurrentOpponentCount;
        }
        
    }
}
