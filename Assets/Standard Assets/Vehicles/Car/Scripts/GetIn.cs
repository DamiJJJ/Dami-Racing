using UnityEngine;

public class GetIn : MonoBehaviour
{
    public AudioSource MyPlayer;

    public void GetInCar()
    {
        MyPlayer.Play();
        SaveScript.CarID = SwapCars.CarNumber;
        SaveScript.CarColor = SaveScript.PreviewCarColor;
        UniversalSave.Saving = true;
    }
}
