using UnityEngine;

public class SwapCars : MonoBehaviour
{
    public GameObject[] Cars;

    public static int CarNumber = 0;
    public void NextCar()
    {
        if (CarNumber < Cars.Length - 1)
        {
            CarNumber++;
        }
        DisplayCars();
    }

    public void LastCar()
    {
        if (CarNumber > 0)
        {
            CarNumber--;
        }
        DisplayCars();
    }

    void DisplayCars()
    {
        for (int i = 0; i < Cars.Length; i++)
        {
            Cars[i].SetActive(false);
            if (i == CarNumber)
            {
                Cars[i].SetActive(true);
            }
        }

    }
}
