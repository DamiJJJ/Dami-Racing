using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScript : MonoBehaviour
{
    public Image SpeedRing;
    public TextMeshProUGUI SpeedText;
    public TextMeshProUGUI GearText;
    public TextMeshProUGUI LapNumberText;
    public TextMeshProUGUI TotalLapsText;
    public TextMeshProUGUI LapTimeMinutesText;
    public TextMeshProUGUI LapTimeSecondsText;
    public TextMeshProUGUI RaceTimeMinutesText;
    public TextMeshProUGUI RaceTimeSecondsText;
    public TextMeshProUGUI BestLapTimeMinutes;
    public TextMeshProUGUI BestLapTimeSeconds;
    public TextMeshProUGUI CheckPointTime;
    public TextMeshProUGUI WrongWayT;
    // Position objects
    public TextMeshProUGUI PlayersPosition;
    public TextMeshProUGUI TotalCarsText;
    public GameObject CheckPointDisplay;
    public GameObject NewLapRecord;
    public GameObject WrongWayText;
    public GameObject PenaltyText;
    private int TotalLaps = 1;
    private int TotalCars = 6;
    private float DisplaySpeed;

    public GameObject[] cars;

    private void Start()
    {
        TotalLaps = UniversalSave.LapCounts;
        TotalCars = UniversalSave.OpponentsCount + 1;
        SpeedRing.fillAmount = 0;
        SpeedText.text = "0";
        GearText.text = "1";
        LapNumberText.text = "0";
        TotalLapsText.text = TotalLaps.ToString("/0");
        CheckPointDisplay.SetActive(false);
        NewLapRecord.SetActive(false);
        WrongWayText.SetActive(false);
        SaveScript.MaxLaps = TotalLaps;
        TotalCarsText.text = TotalCars.ToString("/0");
        PlayersPosition.text = "1";
        SetCarVisibility();
    }

    void SetCarVisibility()
    {
        switch(TotalCars)
        {
            case 2:
            cars[0].SetActive(true);
            for(int i = 1; i <= cars.Length - 1; i++)
            {
                cars[i].SetActive(false);
            }
            break;
            case 3:
            cars[0].SetActive(true);
            cars[1].SetActive(true);
            for(int i = 2; i <= cars.Length - 1; i++)
            {
                cars[i].SetActive(false);
            }
            break;
            case 4:
            cars[0].SetActive(true);
            cars[1].SetActive(true);
            cars[2].SetActive(true);
            for(int i = 3; i <= cars.Length - 1; i++)
            {
                cars[i].SetActive(false);
            }
            break;
            case 5:
            cars[0].SetActive(true);
            cars[1].SetActive(true);
            cars[2].SetActive(true);
            cars[3].SetActive(true);
            for(int i = 4; i <= cars.Length - 1; i++)
            {
                cars[i].SetActive(false);
            }
            break;
            case 6:
            cars[5].SetActive(false);
            cars[6].SetActive(false);
            for(int i = 0; i <= 4; i++)
            {
                cars[i].SetActive(true);
            }
            break;
            case 7:
            cars[6].SetActive(false);
            for(int i = 0; i <= 5; i++)
            {
                cars[i].SetActive(true);
            }
            break;
            case 8:
            for(int i = 0; i <= cars.Length - 1; i++)
            {
                cars[i].SetActive(true);
            }
            break;
        }
    }

    private void Update()
    {
        // Speedometer
        DisplaySpeed = SaveScript.Speed / SaveScript.TopSpeed;
        SpeedRing.fillAmount = DisplaySpeed;
        SpeedText.text = Mathf.Round(SaveScript.Speed).ToString();
        GearText.text = (SaveScript.Gear + 1).ToString();

        // LapNumber
        LapNumberText.text = SaveScript.LapNumber.ToString();

        // LapTime
        LapTimeMinutesText.text = Mathf.Round(SaveScript.LapTimeMinutes).ToString("00:");
        LapTimeSecondsText.text = Mathf.Round(SaveScript.LapTimeSeconds).ToString("00");

        // RaceTime
        RaceTimeMinutesText.text = Mathf.Round(SaveScript.RaceTimeMinutes).ToString("00:");
        RaceTimeSecondsText.text = Mathf.Round(SaveScript.RaceTimeSeconds).ToString("00");

        // Working out BestLapTime
        if(SaveScript.LapChange == true)
        {
            if(SaveScript.LastLapM == SaveScript.BestLapTimeM)
            {
                if(SaveScript.LastLapS < SaveScript.BestLapTimeS)
                {
                    SaveScript.BestLapTimeS = SaveScript.LastLapS;
                    SaveScript.NewRecord = true;
                }
            }
            if(SaveScript.LastLapM < SaveScript.BestLapTimeM)
            {
                SaveScript.BestLapTimeM = SaveScript.LastLapM;
                SaveScript.BestLapTimeS = SaveScript.LastLapS;
                SaveScript.NewRecord = true;
            }
        }
        
        // Display BestLapTime
        BestLapTimeMinutes.text = Mathf.Round(SaveScript.BestLapTimeM).ToString("00:");
        BestLapTimeSeconds.text = Mathf.Round(SaveScript.BestLapTimeS).ToString("00");

        if(SaveScript.NewRecord == true)
        {
            NewLapRecord.SetActive(true);
            StartCoroutine(LapRecordOff());
        }

        // CheckPoints
        // CheckPoint 1
        if(SaveScript.CheckPointPass1 == true)
        {
            SaveScript.CheckPointPass1 = false;
            if(SaveScript.LapNumber > 1)
            {
                CheckPointDisplay.SetActive(true);

                if(SaveScript.ThisCheckPoint1 > SaveScript.LastCheckPoint1)
                {
                    CheckPointTime.color = Color.red;
                    CheckPointTime.text = (SaveScript.ThisCheckPoint1 - SaveScript.LastCheckPoint1).ToString("-0.000", System.Globalization.CultureInfo.InvariantCulture);
                    StartCoroutine(CheckPointOff());
                }
                if(SaveScript.ThisCheckPoint1 < SaveScript.LastCheckPoint1)
                {
                    CheckPointTime.color = Color.green;
                    CheckPointTime.text = (SaveScript.LastCheckPoint1 - SaveScript.ThisCheckPoint1).ToString("+0.000", System.Globalization.CultureInfo.InvariantCulture);
                    StartCoroutine(CheckPointOff());
                }
            }           
        }
        // CheckPoint 2
        if(SaveScript.CheckPointPass2 == true)
        {
            SaveScript.CheckPointPass2 = false;
            if(SaveScript.LapNumber > 1)
            {
                CheckPointDisplay.SetActive(true);

                if(SaveScript.ThisCheckPoint2 > SaveScript.LastCheckPoint2)
                {
                    CheckPointTime.color = Color.red;
                    CheckPointTime.text = (SaveScript.ThisCheckPoint2 - SaveScript.LastCheckPoint2).ToString("-0.000", System.Globalization.CultureInfo.InvariantCulture);
                    StartCoroutine(CheckPointOff());
                }
                if(SaveScript.ThisCheckPoint2 < SaveScript.LastCheckPoint2)
                {
                    CheckPointTime.color = Color.green;
                    CheckPointTime.text = (SaveScript.LastCheckPoint2 - SaveScript.ThisCheckPoint2).ToString("+0.000", System.Globalization.CultureInfo.InvariantCulture);
                    StartCoroutine(CheckPointOff());
                }
            }        
        }
        // CheckPoint 3
        if(SaveScript.CheckPointPass3 == true)
        {
            SaveScript.CheckPointPass3 = false;
            if(SaveScript.LapNumber > 1)
            {
                CheckPointDisplay.SetActive(true);

                if(SaveScript.ThisCheckPoint3 > SaveScript.LastCheckPoint3)
                {
                    CheckPointTime.color = Color.red;
                    CheckPointTime.text = (SaveScript.ThisCheckPoint3 - SaveScript.LastCheckPoint3).ToString("-0.000", System.Globalization.CultureInfo.InvariantCulture);
                    StartCoroutine(CheckPointOff());
                }
                if(SaveScript.ThisCheckPoint3 < SaveScript.LastCheckPoint3)
                {
                    CheckPointTime.color = Color.green;
                    CheckPointTime.text = (SaveScript.LastCheckPoint3 - SaveScript.ThisCheckPoint3).ToString("+0.000", System.Globalization.CultureInfo.InvariantCulture);
                    StartCoroutine(CheckPointOff());
                }
            } 
        }

        // WrongWay message
        if(SaveScript.WrongWay)
        {
            WrongWayText.SetActive(true);
        }
        else
        {
            WrongWayText.SetActive(false);
        }

        // WrongWay Reset Text
        if(!SaveScript.WWTextReset)
        {
            WrongWayT.text = "wrong way!";
        }
        if(SaveScript.WWTextReset)
        {
            WrongWayT.text = " ";
        }

        // Display Position
        PlayersPosition.text = SaveScript.PlayerPosition.ToString();

        //! Display Penalty Label (INDEV)
        if(SaveScript.Penalty)
        {
            StartCoroutine(showPenalty());
            SaveScript.Penalty = false;
        }
    }

    IEnumerator CheckPointOff()
    {
        yield return new WaitForSeconds(2);
        CheckPointDisplay.SetActive(false);
    }
    IEnumerator LapRecordOff()
    {
        yield return new WaitForSeconds(2);
        SaveScript.NewRecord = false;
        NewLapRecord.SetActive(false);
    }
    IEnumerator showPenalty()
    {
        PenaltyText.SetActive(true);
        yield return new WaitForSeconds(2);
        PenaltyText.SetActive(false);
    }
}
