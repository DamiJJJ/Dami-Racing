using UnityEngine;

public class ProgressWaypoints : MonoBehaviour
{
    public int WPNumber;
    public int CarTracking = 0;
    public bool PenaltyOption = false;
    public int PenaltyWayPoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Progress"))
        {
            CarTracking = other.GetComponent<ProgressTracker>().CurrentWP;
            if(CarTracking < WPNumber)
            {
                other.GetComponent<ProgressTracker>().CurrentWP = WPNumber;
                Debug.Log("CurrentWP =" + other.GetComponent<ProgressTracker>().CurrentWP);
            }
            if(CarTracking > WPNumber)
            {
                Debug.Log("Wrong way");
                SaveScript.WrongWay = true;
            }
            if(PenaltyOption)
            {
                if(CarTracking < PenaltyWayPoint)
                {
                    Debug.Log("Penalty");
                }
            }
        }
    }
}
