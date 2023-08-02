using System.Collections;
using UnityEngine;
using TMPro;

public class RaceTrackMenu : MonoBehaviour
{
    public GameObject TrackOptions;
    public bool F1Race = false;
    public TextMeshProUGUI WrongCar;

    public void OptionsOn()
    {
        TrackOptions.SetActive(true);

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
