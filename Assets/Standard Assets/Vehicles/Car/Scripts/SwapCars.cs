using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SwapCars : MonoBehaviour
{
    [System.Serializable]
    public struct Cars
    {
        public GameObject Car;
        [Range(0f, 1f)]
        public float CarSpeed;
        [Range(0f, 1f)]
        public float CarBraking;
        [Range(0f, 1f)]
        public float CarHandling;
        public int Price;
        public bool Owned;
    }

    public Cars[] AvailableCars;

    public TextMeshProUGUI Credits;
    public TextMeshProUGUI Price;
    public static int CarNumber = 0;

    public Image SpeedBar;
    public Image BrakingBar;
    public Image HandlingBar;
    public GameObject BuyButton;
    public GameObject GetInButton;

    private void Start()
    {
        Credits.text = UniversalSave.CreditAmount.ToString();
        BuyButton.SetActive(false);
        GetInButton.SetActive(true);
        DisplayCars();
    }
    public void NextCar()
    {
        if (CarNumber < AvailableCars.Length - 1)
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
        AvailableCars[CarNumber].Owned = UniversalSave.CarOwned[CarNumber];
        for (int i = 0; i < AvailableCars.Length; i++)
        {
            AvailableCars[i].Car.SetActive(false);
            if (i == CarNumber)
            {
                AvailableCars[i].Car.SetActive(true);
                SpeedBar.fillAmount = AvailableCars[i].CarSpeed;
                BrakingBar.fillAmount = AvailableCars[i].CarBraking;
                HandlingBar.fillAmount = AvailableCars[i].CarHandling;
                if (!AvailableCars[i].Owned)
                {
                    BuyButton.SetActive(true);
                    GetInButton.SetActive(false);
                    Price.text = AvailableCars[i].Price.ToString();
                }
                else
                {
                    BuyButton.SetActive(false);
                    GetInButton.SetActive(true);
                    Price.text = "Owned";
                }
            }
        }
    }

    public void Buy()
    {
        if(UniversalSave.CreditAmount > AvailableCars[CarNumber].Price)
        {
            SaveScript.CarID = CarNumber;
            SaveScript.CarColor = SaveScript.PreviewCarColor;
            UniversalSave.CreditAmount -= AvailableCars[CarNumber].Price;
            AvailableCars[CarNumber].Owned = true;
            UniversalSave.CarOwned[CarNumber] = AvailableCars[CarNumber].Owned;
            Credits.text = UniversalSave.CreditAmount.ToString();
            UniversalSave.Saving = true;
            DisplayCars();
        }
    }
}
