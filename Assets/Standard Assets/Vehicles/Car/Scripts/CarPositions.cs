using UnityEngine;

public class CarPositions : MonoBehaviour
{
    public GameObject Slot1;
    public GameObject Slot2;
    public GameObject Slot3;
    public GameObject Slot4;
    public GameObject Slot5;
    public GameObject Slot6;
    public GameObject Slot7;
    public GameObject Slot8;

    public GameObject Stats;
    
    public int AICarNumber;
    public bool Player;
    private int Pos;

    private void Start()
    {
        if(AICarNumber == 1)
        {
            Pos = FinishLineAI.AICar1FinishPos;
        }
        if(AICarNumber == 2)
        {
            Pos = FinishLineAI.AICar2FinishPos;
        }
        if(AICarNumber == 3)
        {
            Pos = FinishLineAI.AICar3FinishPos;
        }
        if(AICarNumber == 4)
        {
            Pos = FinishLineAI.AICar4FinishPos;
        }
        if(AICarNumber == 5)
        {
            Pos = FinishLineAI.AICar5FinishPos;
        }
        if(AICarNumber == 6)
        {
            Pos = FinishLineAI.AICar6FinishPos;
        }
        if(AICarNumber == 7)
        {
            Pos = FinishLineAI.AICar7FinishPos;
        }
        if(Player)
        {
            Pos = FinishLine.PLayerFinishPosition;
        }
    }

    private void Update()
    {
        if(Pos == 0)
        {
            Stats.SetActive(false);
        }
        switch (Pos)
        {
            case 1:
                Stats.transform.position = Slot1.transform.position;
                break;
            case 2:
                Stats.transform.position = Slot2.transform.position;
                break;
            case 3:
                Stats.transform.position = Slot3.transform.position;
                break;
            case 4:
                Stats.transform.position = Slot4.transform.position;
                break;
            case 5:
                Stats.transform.position = Slot5.transform.position;
                break;
            case 6:
                Stats.transform.position = Slot6.transform.position;
                break;
            case 7:
                Stats.transform.position = Slot7.transform.position;
                break;
            case 8:
                Stats.transform.position = Slot8.transform.position;
                break;
            default:
                break;
        }
    }
}
