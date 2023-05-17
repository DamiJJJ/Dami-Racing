using System.Collections;
using UnityEngine;

public class Lap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SaveScript.WWTextReset = true;
            StartCoroutine(WrongWayReset());
            if(!SaveScript.RaceOver)
            {
                if(SaveScript.HalfWayActivated)
                {
                    SaveScript.HalfWayActivated = false;
                    SaveScript.LastLapM = SaveScript.LapTimeMinutes;
                    SaveScript.LastLapS = SaveScript.LapTimeSeconds;
                    SaveScript.LapNumber++;
                    SaveScript.LapChange = true;
                    if(SaveScript.LapNumber == 2)
                    {
                        SaveScript.BestLapTimeM = SaveScript.LastLapM;
                        SaveScript.BestLapTimeS = SaveScript.LastLapS;
                        SaveScript.NewRecord = true;
                    }
                    SaveScript.CheckPointPass1 = false;
                    SaveScript.CheckPointPass2 = false;
                    SaveScript.CheckPointPass3 = false;
                    SaveScript.LastCheckPoint1 = SaveScript.ThisCheckPoint1;
                    SaveScript.LastCheckPoint2 = SaveScript.ThisCheckPoint2;
                    SaveScript.LastCheckPoint3 = SaveScript.ThisCheckPoint3;
                }
            }
        }

        if(other.gameObject.CompareTag("ProgressAI1"))
        {
            SaveScript.AICar1LapNumber++;
        }
        if(other.gameObject.CompareTag("ProgressAI2"))
        {
            SaveScript.AICar2LapNumber++;
        }
        if(other.gameObject.CompareTag("ProgressAI3"))
        {
            SaveScript.AICar3LapNumber++;
        }
        if(other.gameObject.CompareTag("ProgressAI4"))
        {
            SaveScript.AICar4LapNumber++;
        }
        if(other.gameObject.CompareTag("ProgressAI5"))
        {
            SaveScript.AICar5LapNumber++;
        }
        if(other.gameObject.CompareTag("ProgressAI6"))
        {
            SaveScript.AICar6LapNumber++;
        }
        if(other.gameObject.CompareTag("ProgressAI7"))
        {
            SaveScript.AICar7LapNumber++;
        }
    }
    IEnumerator WrongWayReset()
    {
        yield return new WaitForSeconds(1.5f);
        SaveScript.WWTextReset = false;
    }
}
