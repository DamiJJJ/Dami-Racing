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
    public int TotalLaps = 3;

    private float DisplaySpeed;

    private void Start()
    {
        SpeedRing.fillAmount = 0;
        SpeedText.text = "0";
        GearText.text = "1";
        LapNumberText.text = "0";
        TotalLapsText.text = TotalLaps.ToString("/0");
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

        // BestLapTime
        if(SaveScript.LastLapM == SaveScript.BestLapTimeM)
        {
            if(SaveScript.LastLapS < SaveScript.BestLapTimeS)
            {
                SaveScript.BestLapTimeS = SaveScript.LastLapS;
            }
        }
        if(SaveScript.LastLapM < SaveScript.BestLapTimeM)
        {
            SaveScript.BestLapTimeM = SaveScript.LastLapM;
            SaveScript.BestLapTimeS = SaveScript.LastLapS;
        }

        BestLapTimeMinutes.text = Mathf.Round(SaveScript.BestLapTimeM).ToString("00:");
        BestLapTimeSeconds.text = Mathf.Round(SaveScript.BestLapTimeS).ToString("00");
    }
}
