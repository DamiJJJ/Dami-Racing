using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UITimeTrial : MonoBehaviour
{
    public TextMeshProUGUI TimeTrialMinutesG;
    public TextMeshProUGUI TimeTrialMinutesS;
    public TextMeshProUGUI TimeTrialMinutesB;
    public TextMeshProUGUI TimeTrialSecondsG;
    public TextMeshProUGUI TimeTrialSecondsS;
    public TextMeshProUGUI TimeTrialSecondsB;
    public GameObject TimeTrialPanel;
    public TextMeshProUGUI WinMessage;
    public GameObject GoldStar;
    public GameObject SilverStar;
    public GameObject BronzeStar;
    public GameObject TimeTrialResults;

    private bool Winner = false;
    private void Start()
    {
        TimeTrialPanel.SetActive(true);
        TimeTrialResults.SetActive(false);  
    }

    private void Update()
    {
        // Setting the timeTrial times
        TimeTrialMinutesG.text = SaveScript.TimeTrialMinG.ToString("00:");
        TimeTrialSecondsG.text = SaveScript.TimeTrialSecondsG.ToString("00");
        TimeTrialMinutesS.text = SaveScript.TimeTrialMinS.ToString("00:");
        TimeTrialSecondsS.text = SaveScript.TimeTrialSecondsS.ToString("00");
        TimeTrialMinutesB.text = SaveScript.TimeTrialMinB.ToString("00:");
        TimeTrialSecondsB.text = SaveScript.TimeTrialSecondsB.ToString("00");
        // Timetrial
        if(SaveScript.RaceOver)
        {
            if(!Winner)
            {
                Winner = true;
                StartCoroutine(WinDisplay());
            }
        }
    }

    IEnumerator WinDisplay()
    {
        yield return new WaitForSeconds(0.15f);
        TimeTrialResults.SetActive(true);
        if(SaveScript.Gold)
        {
            WinMessage.text = "You won gold";
            GoldStar.SetActive(true);
        }
        if(SaveScript.Silver)
        {
            WinMessage.text = "You won silver";
            SilverStar.SetActive(true);
        }
        if(SaveScript.Bronze)
        {
            WinMessage.text = "You won bronze";
            BronzeStar.SetActive(true);
        }
        if(SaveScript.Fail)
        {
            WinMessage.text = "try again";
        }
    }
}
