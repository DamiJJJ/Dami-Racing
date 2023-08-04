using System.Collections;
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

    [System.Serializable]
    public struct RaceModes
    {
        public int SceneNumber;
        public string Name;
        public bool TimeTrial;
    }

    public RaceModes[] AvailableModes;

    // private bool TimeTrial = true;
    private int Counter = 0;
    private int CurrentLapCount = 1;
    private int CurrentOpponentCount = 1;

    public void ModeNext()
    {
        if (Counter < AvailableModes.Length - 1)
        {
            Counter++;
            Mode.text = AvailableModes[Counter].Name;
            if (AvailableModes[Counter].TimeTrial)
            {
                OpponentsOn.SetActive(false);
                LapsOn.SetActive(false);
            }
            else if (!AvailableModes[Counter].TimeTrial)
            {
                OpponentsOn.SetActive(true);
                LapsOn.SetActive(true);
            }
        }
    }

    public void ModeBack()
    {
        if (Counter > 0)
        {
            Counter--;
            Mode.text = AvailableModes[Counter].Name;
            if (AvailableModes[Counter].TimeTrial)
            {
                OpponentsOn.SetActive(false);
                LapsOn.SetActive(false);
            }
            else if (!AvailableModes[Counter].TimeTrial)
            {
                OpponentsOn.SetActive(true);
                LapsOn.SetActive(true);
            }
        }
    }

    public void LapCountNext()
    {
        if (CurrentLapCount < 12)
        {
            CurrentLapCount++;
            LapCount.text = CurrentLapCount + " LAPS";
            UniversalSave.LapCounts = CurrentLapCount;
        }
    }

    public void LapCountBack()
    {
        if (CurrentLapCount > 2)
        {
            CurrentLapCount--;
            LapCount.text = CurrentLapCount + " LAPS";
            UniversalSave.LapCounts = CurrentLapCount;
        }
        else if (CurrentLapCount == 2)
        {
            CurrentLapCount--;
            LapCount.text = CurrentLapCount + " LAP";
            UniversalSave.LapCounts = CurrentLapCount;
        }
    }

    public void OpponentNext()
    {
        if (CurrentOpponentCount < 7)
        {
            CurrentOpponentCount++;
            OpponentCount.text = CurrentOpponentCount + " OPPONENTS";
            UniversalSave.OpponentsCount = CurrentOpponentCount;
        }
    }
    public void OpponentBack()
    {
        if (CurrentOpponentCount > 2)
        {
            CurrentOpponentCount--;
            OpponentCount.text = CurrentOpponentCount + " OPPONENTS";
            UniversalSave.OpponentsCount = CurrentOpponentCount;
        }
        else if (CurrentOpponentCount == 2)
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

    void ResetValues()
    {
        Time.timeScale = 1.0f;
        SaveScript.LapNumber = 0;
        SaveScript.LapChange = false;
        SaveScript.LapTimeMinutes = 0.0f;
        SaveScript.LapTimeSeconds = 0.0f;
        SaveScript.RaceTimeMinutes = 0.0f;
        SaveScript.RaceTimeSeconds = 0.0f;
        SaveScript.LastLapM = 0.0f;
        SaveScript.LastLapS = 0.0f;
        SaveScript.GameTime = 0.0f;
        SaveScript.LastCheckPoint1 = 0.0f;
        SaveScript.LastCheckPoint2 = 0.0f;
        SaveScript.LastCheckPoint3 = 0.0f;
        SaveScript.ThisCheckPoint1 = 0.0f;
        SaveScript.ThisCheckPoint2 = 0.0f;
        SaveScript.ThisCheckPoint3 = 0.0f;
        SaveScript.CheckPointPass1 = false;
        SaveScript.CheckPointPass2 = false;
        SaveScript.CheckPointPass3 = false;
        SaveScript.HalfWayActivated = true;
        SaveScript.RaceStart = false;
        SaveScript.RaceOver = false;
        SaveScript.PlayerPosition = 0;
        SaveScript.Gold = false;
        SaveScript.Silver = false;
        SaveScript.Bronze = false;
        SaveScript.Fail = false;
        SaveScript.PenaltySeconds = 0;
        SaveScript.AICar1LapNumber = 0;
        SaveScript.AICar2LapNumber = 0;
        SaveScript.AICar3LapNumber = 0;
        SaveScript.AICar4LapNumber = 0;
        SaveScript.AICar5LapNumber = 0;
        SaveScript.AICar6LapNumber = 0;
        SaveScript.AICar7LapNumber = 0;
        SaveScript.FinishPositionID = 0;
    }

    IEnumerator WaitToLoad()
    {
        ResetValues();
        yield return new WaitForSeconds(0.3f);
        LoadScreen.SetActive(true);
        if (AvailableModes[Counter].TimeTrial)
        {
            UniversalSave.LapCounts = 1;
            UniversalSave.OpponentsCount = 0;
            SceneManager.LoadScene(AvailableModes[Counter].SceneNumber);
        }
        if (!AvailableModes[Counter].TimeTrial)
        {
            UniversalSave.LapCounts = CurrentLapCount;
            SceneManager.LoadScene(AvailableModes[Counter].SceneNumber);
            UniversalSave.OpponentsCount = CurrentOpponentCount;
        }

    }
}
