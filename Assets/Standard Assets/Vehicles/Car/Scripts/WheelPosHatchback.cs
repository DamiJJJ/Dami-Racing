using UnityEngine;

public class WheelPosHatchback : MonoBehaviour
{
    private void Update()
    {
        if (SaveScript.RaceStart)
        {
            transform.Rotate(0, -90, 0);
        }
    }
}
