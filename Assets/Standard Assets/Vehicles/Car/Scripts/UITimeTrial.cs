using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UITimeTrial : MonoBehaviour
{
    public TextMeshProUGUI TimeTrialMinutesG;
    public TextMeshProUGUI TimeTrialMinutesS;
    public TextMeshProUGUI TimeTrialMinutesB;
    public TextMeshProUGUI TimeTrialSecondsG;
    public TextMeshProUGUI TimeTrialSecondsS;
    public TextMeshProUGUI TimeTrialSecondsB;
    public TextMeshProUGUI Credits;
    public GameObject TimeTrialPanel;
    public TextMeshProUGUI WinMessage;
    public GameObject GoldStar;
    public GameObject SilverStar;
    public GameObject BronzeStar;
    public GameObject TimeTrialResults;
    // public GameObject QuitPanel;

    public int GoldCredits = 3000;
    public int SilverCredits = 1500;
    public int BronzeCredits = 700;

    private bool Winner = false;
    private void Start()
    {
        TimeTrialPanel.SetActive(true);
        TimeTrialResults.SetActive(false);  
        // QuitPanel.SetActive(false);
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
            WinMessage.text = "gold";
            GoldStar.SetActive(true);
            Credits.text = GoldCredits.ToString();
            UniversalSave.CreditAmount += GoldCredits;
            UniversalSave.RacesWon++;
        }
        if(SaveScript.Silver)
        {
            WinMessage.text = "silver";
            SilverStar.SetActive(true);
            Credits.text = SilverCredits.ToString();
            UniversalSave.CreditAmount += SilverCredits;
            UniversalSave.RacesWon++;
        }
        if(SaveScript.Bronze)
        {
            WinMessage.text = "bronze";
            BronzeStar.SetActive(true);
            Credits.text = BronzeCredits.ToString();
            UniversalSave.CreditAmount += BronzeCredits;
            UniversalSave.RacesWon++;
        }
        if(SaveScript.Fail)
        {
            WinMessage.text = "try again";
            Credits.text = "0";
            UniversalSave.RacesLost++;
        }
        UniversalSave.Saving = true;
    }
}
