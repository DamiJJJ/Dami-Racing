using UnityEngine;

public class GetIn : MonoBehaviour
{
    public void GetInCar()
    {
        SaveScript.CarID = SwapCars.CarNumber;
        SaveScript.CarColor = SaveScript.PreviewCarColor;
    }
}
