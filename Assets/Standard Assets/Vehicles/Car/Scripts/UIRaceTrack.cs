using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIRaceTrack : MonoBehaviour
{
    public TextMeshProUGUI WinMessage;
    public GameObject Leaderboard;

    private void Start()
    {
        Leaderboard.SetActive(false);
        switch(FinishLine.PLayerFinishPosition)
        {
            case 1:
            WinMessage.text = "1st place";
            break;

            case 2:
            WinMessage.text = "2nd place";
            break;

            case 3:
            WinMessage.text = "3rd place";
            break;
        }
        if(FinishLine.PLayerFinishPosition > 3)
        {
            WinMessage.text = FinishLine.PLayerFinishPosition + "th place";
        }
    }

    public void DisplayLeaderboard()
    {
        Leaderboard.SetActive(true);
        this.gameObject.SetActive(false);
        Time.timeScale = 0;
    }
}
