using UnityEngine;

public class WheelPos : MonoBehaviour
{
    private void Update()
    {
        if (SaveScript.RaceStart)
        {
            transform.Rotate(0, -180, 0);
        }
    }
}
