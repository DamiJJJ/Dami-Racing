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
    // Time Trial objects
    public TextMeshProUGUI TimeTrialMinutesG;
    public TextMeshProUGUI TimeTrialMinutesS;
    public TextMeshProUGUI TimeTrialMinutesB;
    public TextMeshProUGUI TimeTrialSecondsG;
    public TextMeshProUGUI TimeTrialSecondsS;
    public TextMeshProUGUI TimeTrialSecondsB;
    public GameObject TimeTrialPanel;
    public GameObject CheckPointDisplay;
    public GameObject NewLapRecord;
    public GameObject WrongWayText;
    public int TotalLaps = 3;

    private float DisplaySpeed;

    private void Start()
    {
        SpeedRing.fillAmount = 0;
        SpeedText.text = "0";
        GearText.text = "1";
        LapNumberText.text = "0";
        TotalLapsText.text = TotalLaps.ToString("/0");
        CheckPointDisplay.SetActive(false);
        NewLapRecord.SetActive(false);
        WrongWayText.SetActive(false);
        SaveScript.MaxLaps = TotalLaps;

        TimeTrialPanel.SetActive(true);
        // Setting the timeTrial times
        TimeTrialMinutesG.text = SaveScript.TimeTrialMinG.ToString("00:");
        TimeTrialSecondsG.text = SaveScript.TimeTrialSecondsG.ToString("00");
        TimeTrialMinutesS.text = SaveScript.TimeTrialMinS.ToString("00:");
        TimeTrialSecondsS.text = SaveScript.TimeTrialSecondsS.ToString("00");
        TimeTrialMinutesB.text = SaveScript.TimeTrialMinB.ToString("00:");
        TimeTrialSecondsB.text = SaveScript.TimeTrialSecondsB.ToString("00");
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
}
