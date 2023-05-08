using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class SaveScript : MonoBehaviour
{
    public static float Speed;
    public static float TopSpeed;
    public static int Gear;
    public static int LapNumber;
    public static bool LapChange = false;
    public static float LapTimeMinutes;
    public static float LapTimeSeconds;

    private void Update()
    {
        if(LapChange == true)
        {
            LapChange = false;
            LapTimeMinutes = 0f;
            LapTimeSeconds = 0f;
        }

        if(LapNumber >= 1)
        {
            LapTimeSeconds = LapTimeSeconds + 1 * Time.deltaTime;
        }
        if(LapTimeSeconds > 59)
        {
            LapTimeSeconds = 0f;
            LapTimeMinutes++;
        }
    }
}
