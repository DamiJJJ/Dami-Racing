using UnityEngine;
using TMPro;

public class UIRaceTrack : MonoBehaviour
{
    public TextMeshProUGUI WinMessage;
    public TextMeshProUGUI Credits;
    public GameObject Leaderboard;
    public int FirstPlaceCredits = 2000;
    public int SecondPlaceCredits = 1000;
    public int ThirdPlaceCredits = 500;

    private void Start()
    {
        Leaderboard.SetActive(false);

        if(UniversalSave.OpponentsCount > 0)
        {
            FirstPlaceCredits *= UniversalSave.OpponentsCount;
            SecondPlaceCredits *= UniversalSave.OpponentsCount;
            ThirdPlaceCredits *= UniversalSave.OpponentsCount;
        }

        switch(FinishLine.PLayerFinishPosition)
        {
            case 1:
            WinMessage.text = "1st place";
            Credits.text = FirstPlaceCredits.ToString();
            UniversalSave.CreditAmount += FirstPlaceCredits;
            UniversalSave.RacesWon++;
            break;

            case 2:
            WinMessage.text = "2nd place";
            Credits.text = SecondPlaceCredits.ToString();
            UniversalSave.CreditAmount += SecondPlaceCredits;
            UniversalSave.RacesWon++;
            break;

            case 3:
            WinMessage.text = "3rd place";
            Credits.text = ThirdPlaceCredits.ToString();
            UniversalSave.CreditAmount += ThirdPlaceCredits;
            UniversalSave.RacesWon++;
            break;
        }
        if(FinishLine.PLayerFinishPosition > 3)
        {
            WinMessage.text = FinishLine.PLayerFinishPosition + "th place";
            Credits.text = "0";
            UniversalSave.RacesLost++;
        }
        UniversalSave.Saving = true;
    }

    public void DisplayLeaderboard()
    {
        Leaderboard.SetActive(true);
        this.gameObject.SetActive(false);
        Time.timeScale = 0;
    }
}
