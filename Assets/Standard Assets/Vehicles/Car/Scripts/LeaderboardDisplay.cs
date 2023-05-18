using UnityEngine;
using TMPro;

public class LeaderboardDisplay : MonoBehaviour
{
    public TextMeshProUGUI Position;
    public TextMeshProUGUI Name;
    public TextMeshProUGUI Results;

    public bool AI1;
    public bool AI2;
    public bool AI3;
    public bool AI4;
    public bool AI5;
    public bool AI6;
    public bool AI7;
    public bool Player;

    private void Update()
    {
        if(AI1)
        {
            Position.text = FinishLineAI.AICar1FinishPos.ToString();
            Name.text = FinishLineAI.AICar1Name.ToString();
            Results.text = FinishLineAI.AICar1RTMinutes.ToString("00") + FinishLineAI.AICar1RTSeconds.ToString(":00");
        }

        if(AI2)
        {
            Position.text = FinishLineAI.AICar2FinishPos.ToString();
            Name.text = FinishLineAI.AICar2Name.ToString();
            Results.text = FinishLineAI.AICar2RTMinutes.ToString("00") + FinishLineAI.AICar2RTSeconds.ToString(":00");
        }

        if(AI3)
        {
            Position.text = FinishLineAI.AICar3FinishPos.ToString();
            Name.text = FinishLineAI.AICar3Name.ToString();
            Results.text = FinishLineAI.AICar3RTMinutes.ToString("00") + FinishLineAI.AICar3RTSeconds.ToString(":00");
        }

        if(AI4)
        {
            Position.text = FinishLineAI.AICar4FinishPos.ToString();
            Name.text = FinishLineAI.AICar4Name.ToString();
            Results.text = FinishLineAI.AICar4RTMinutes.ToString("00") + FinishLineAI.AICar4RTSeconds.ToString(":00");
        }

        if(AI5)
        {
            Position.text = FinishLineAI.AICar5FinishPos.ToString();
            Name.text = FinishLineAI.AICar5Name.ToString();
            Results.text = FinishLineAI.AICar5RTMinutes.ToString("00") + FinishLineAI.AICar5RTSeconds.ToString(":00");
        }

        if(AI6)
        {
            Position.text = FinishLineAI.AICar6FinishPos.ToString();
            Name.text = FinishLineAI.AICar6Name.ToString();
            Results.text = FinishLineAI.AICar6RTMinutes.ToString("00") + FinishLineAI.AICar6RTSeconds.ToString(":00");
        }

        if(AI7)
        {
            Position.text = FinishLineAI.AICar7FinishPos.ToString();
            Name.text = FinishLineAI.AICar7Name.ToString();
            Results.text = FinishLineAI.AICar7RTMinutes.ToString("00") + FinishLineAI.AICar7RTSeconds.ToString(":00");
        }  

        if(Player)
        {
            Position.text = FinishLine.PLayerFinishPosition.ToString();
            Name.text = FinishLine.PName;
            Results.text = SaveScript.RaceTimeMinutes.ToString("00") + SaveScript.RaceTimeSeconds.ToString(":00");
        }     
    }
}
