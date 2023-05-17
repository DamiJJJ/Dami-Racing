using UnityEngine;

public class ProgressWaypoints : MonoBehaviour
{
    public int WPNumber;
    public int CarTracking = 0;
    public bool PenaltyOption = false;
    public int PenaltyWayPoint;
    public int Position = 0;

    public int Lap1Position = 0;
    public int Lap2Position = 0;
    public int Lap3Position = 0;
    public int Lap4Position = 0;
    public int Lap5Position = 0;
    public int Lap6Position = 0;
    public int Lap7Position = 0;
    public int Lap8Position = 0;
    public int Lap9Position = 0;
    public int Lap10Position = 0;
    public int Lap11Position = 0;
    public int Lap12Position = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Progress"))
        {
            CarTracking = other.GetComponent<ProgressTracker>().CurrentWP;
            if(CarTracking < WPNumber)
            {
                other.GetComponent<ProgressTracker>().CurrentWP = WPNumber;
                Position++;
                SaveScript.PlayerPosition = Position;
            }
            if(CarTracking > WPNumber)
            {
                other.GetComponent<ProgressTracker>().LastWPNumber = WPNumber;
            }
            if(PenaltyOption)
            {
                if(CarTracking < PenaltyWayPoint)
                {
                    SaveScript.Penalty = true;
                    SaveScript.PenaltySeconds += 10f;
                    PenaltyOption = false;
                }
            }
        }

        if(other.gameObject.CompareTag("ProgressAI1"))
        {
            if(SaveScript.AICar1LapNumber == 1)
            {
                Lap1Position++;
            }
            if(SaveScript.AICar1LapNumber == 2)
            {
                Lap2Position++;
            }
            if(SaveScript.AICar1LapNumber == 3)
            {
                Lap3Position++;
            }
            if(SaveScript.AICar1LapNumber == 4)
            {
                Lap4Position++;
            }
            if(SaveScript.AICar1LapNumber == 5)
            {
                Lap5Position++;
            }
            if(SaveScript.AICar1LapNumber == 6)
            {
                Lap6Position++;
            }
            if(SaveScript.AICar1LapNumber == 7)
            {
                Lap7Position++;
            }
            if(SaveScript.AICar1LapNumber == 8)
            {
                Lap8Position++;
            }
            if(SaveScript.AICar1LapNumber == 9)
            {
                Lap9Position++;
            }
            if(SaveScript.AICar1LapNumber == 10)
            {
                Lap10Position++;
            }
            if(SaveScript.AICar1LapNumber == 11)
            {
                Lap11Position++;
            }
            if(SaveScript.AICar1LapNumber == 12)
            {
                Lap12Position++;
            }
        }
        if(other.gameObject.CompareTag("ProgressAI2"))
        {
            if(SaveScript.AICar1LapNumber == 1)
            {
                Lap1Position++;
            }
            if(SaveScript.AICar1LapNumber == 2)
            {
                Lap2Position++;
            }
            if(SaveScript.AICar1LapNumber == 3)
            {
                Lap3Position++;
            }
            if(SaveScript.AICar1LapNumber == 4)
            {
                Lap4Position++;
            }
            if(SaveScript.AICar1LapNumber == 5)
            {
                Lap5Position++;
            }
            if(SaveScript.AICar1LapNumber == 6)
            {
                Lap6Position++;
            }
            if(SaveScript.AICar1LapNumber == 7)
            {
                Lap7Position++;
            }
            if(SaveScript.AICar1LapNumber == 8)
            {
                Lap8Position++;
            }
            if(SaveScript.AICar1LapNumber == 9)
            {
                Lap9Position++;
            }
            if(SaveScript.AICar1LapNumber == 10)
            {
                Lap10Position++;
            }
            if(SaveScript.AICar1LapNumber == 11)
            {
                Lap11Position++;
            }
            if(SaveScript.AICar1LapNumber == 12)
            {
                Lap12Position++;
            }
        }
        if(other.gameObject.CompareTag("ProgressAI3"))
        {
            if(SaveScript.AICar1LapNumber == 1)
            {
                Lap1Position++;
            }
            if(SaveScript.AICar1LapNumber == 2)
            {
                Lap2Position++;
            }
            if(SaveScript.AICar1LapNumber == 3)
            {
                Lap3Position++;
            }
            if(SaveScript.AICar1LapNumber == 4)
            {
                Lap4Position++;
            }
            if(SaveScript.AICar1LapNumber == 5)
            {
                Lap5Position++;
            }
            if(SaveScript.AICar1LapNumber == 6)
            {
                Lap6Position++;
            }
            if(SaveScript.AICar1LapNumber == 7)
            {
                Lap7Position++;
            }
            if(SaveScript.AICar1LapNumber == 8)
            {
                Lap8Position++;
            }
            if(SaveScript.AICar1LapNumber == 9)
            {
                Lap9Position++;
            }
            if(SaveScript.AICar1LapNumber == 10)
            {
                Lap10Position++;
            }
            if(SaveScript.AICar1LapNumber == 11)
            {
                Lap11Position++;
            }
            if(SaveScript.AICar1LapNumber == 12)
            {
                Lap12Position++;
            }
        }
        if(other.gameObject.CompareTag("ProgressAI4"))
        {
            if(SaveScript.AICar1LapNumber == 1)
            {
                Lap1Position++;
            }
            if(SaveScript.AICar1LapNumber == 2)
            {
                Lap2Position++;
            }
            if(SaveScript.AICar1LapNumber == 3)
            {
                Lap3Position++;
            }
            if(SaveScript.AICar1LapNumber == 4)
            {
                Lap4Position++;
            }
            if(SaveScript.AICar1LapNumber == 5)
            {
                Lap5Position++;
            }
            if(SaveScript.AICar1LapNumber == 6)
            {
                Lap6Position++;
            }
            if(SaveScript.AICar1LapNumber == 7)
            {
                Lap7Position++;
            }
            if(SaveScript.AICar1LapNumber == 8)
            {
                Lap8Position++;
            }
            if(SaveScript.AICar1LapNumber == 9)
            {
                Lap9Position++;
            }
            if(SaveScript.AICar1LapNumber == 10)
            {
                Lap10Position++;
            }
            if(SaveScript.AICar1LapNumber == 11)
            {
                Lap11Position++;
            }
            if(SaveScript.AICar1LapNumber == 12)
            {
                Lap12Position++;
            }
        }
        if(other.gameObject.CompareTag("ProgressAI5"))
        {
            if(SaveScript.AICar1LapNumber == 1)
            {
                Lap1Position++;
            }
            if(SaveScript.AICar1LapNumber == 2)
            {
                Lap2Position++;
            }
            if(SaveScript.AICar1LapNumber == 3)
            {
                Lap3Position++;
            }
            if(SaveScript.AICar1LapNumber == 4)
            {
                Lap4Position++;
            }
            if(SaveScript.AICar1LapNumber == 5)
            {
                Lap5Position++;
            }
            if(SaveScript.AICar1LapNumber == 6)
            {
                Lap6Position++;
            }
            if(SaveScript.AICar1LapNumber == 7)
            {
                Lap7Position++;
            }
            if(SaveScript.AICar1LapNumber == 8)
            {
                Lap8Position++;
            }
            if(SaveScript.AICar1LapNumber == 9)
            {
                Lap9Position++;
            }
            if(SaveScript.AICar1LapNumber == 10)
            {
                Lap10Position++;
            }
            if(SaveScript.AICar1LapNumber == 11)
            {
                Lap11Position++;
            }
            if(SaveScript.AICar1LapNumber == 12)
            {
                Lap12Position++;
            }
        }
        if(other.gameObject.CompareTag("ProgressAI6"))
        {
            if(SaveScript.AICar1LapNumber == 1)
            {
                Lap1Position++;
            }
            if(SaveScript.AICar1LapNumber == 2)
            {
                Lap2Position++;
            }
            if(SaveScript.AICar1LapNumber == 3)
            {
                Lap3Position++;
            }
            if(SaveScript.AICar1LapNumber == 4)
            {
                Lap4Position++;
            }
            if(SaveScript.AICar1LapNumber == 5)
            {
                Lap5Position++;
            }
            if(SaveScript.AICar1LapNumber == 6)
            {
                Lap6Position++;
            }
            if(SaveScript.AICar1LapNumber == 7)
            {
                Lap7Position++;
            }
            if(SaveScript.AICar1LapNumber == 8)
            {
                Lap8Position++;
            }
            if(SaveScript.AICar1LapNumber == 9)
            {
                Lap9Position++;
            }
            if(SaveScript.AICar1LapNumber == 10)
            {
                Lap10Position++;
            }
            if(SaveScript.AICar1LapNumber == 11)
            {
                Lap11Position++;
            }
            if(SaveScript.AICar1LapNumber == 12)
            {
                Lap12Position++;
            }
        }
        if(other.gameObject.CompareTag("ProgressAI7"))
        {
            if(SaveScript.AICar1LapNumber == 1)
            {
                Lap1Position++;
            }
            if(SaveScript.AICar1LapNumber == 2)
            {
                Lap2Position++;
            }
            if(SaveScript.AICar1LapNumber == 3)
            {
                Lap3Position++;
            }
            if(SaveScript.AICar1LapNumber == 4)
            {
                Lap4Position++;
            }
            if(SaveScript.AICar1LapNumber == 5)
            {
                Lap5Position++;
            }
            if(SaveScript.AICar1LapNumber == 6)
            {
                Lap6Position++;
            }
            if(SaveScript.AICar1LapNumber == 7)
            {
                Lap7Position++;
            }
            if(SaveScript.AICar1LapNumber == 8)
            {
                Lap8Position++;
            }
            if(SaveScript.AICar1LapNumber == 9)
            {
                Lap9Position++;
            }
            if(SaveScript.AICar1LapNumber == 10)
            {
                Lap10Position++;
            }
            if(SaveScript.AICar1LapNumber == 11)
            {
                Lap11Position++;
            }
            if(SaveScript.AICar1LapNumber == 12)
            {
                Lap12Position++;
            }
        }
    }
}
