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
        DisplaySpeed = SaveScript.Speed / SaveScript.TopSpeed;
        SpeedRing.fillAmount = DisplaySpeed;
        SpeedText.text = Mathf.Round(SaveScript.Speed).ToString();
        GearText.text = (SaveScript.Gear + 1).ToString();
        LapNumberText.text = SaveScript.LapNumber.ToString();
    }
}
