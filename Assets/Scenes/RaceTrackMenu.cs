using System.Collections;
using UnityEngine;
using TMPro;

public class RaceTrackMenu : MonoBehaviour
{
    public GameObject TrackOptions;
    public bool F1Race = false;
    public TextMeshProUGUI WrongCar;

    // TODO2: Remove F1 availability to be bought, instead make a new race type called F1
    public void OptionsOn()
    {
        if (F1Race)
        {
            // if (SaveScript.CarID == 0)
            // {
                TrackOptions.SetActive(true);
                WrongCar.text = " ";
            // }
            // else
            // {
            //     WrongCar.text = "you need to be using F1 car";
            //     StartCoroutine(ResetText());
            // }
        }
        if (!F1Race)
        {
            // if (SaveScript.CarID > 0)
            // {
                TrackOptions.SetActive(true);
                WrongCar.text = " ";
            // }
            // else
            // {
            //     WrongCar.text = "you need to be using sports car";
            //     StartCoroutine(ResetText());
            // }
        }
    }

    public void OptionsOff()
    {
        TrackOptions.SetActive(false);
    }

    IEnumerator ResetText()
    {
        yield return new WaitForSeconds(3);
        WrongCar.text = " ";
    }
}
