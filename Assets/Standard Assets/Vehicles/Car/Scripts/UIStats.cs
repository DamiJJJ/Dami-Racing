using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIStats : MonoBehaviour
{
    public TextMeshProUGUI NameDisplay;
    public TextMeshProUGUI NewName;
    public TextMeshProUGUI RacesWonDisplay;
    public TextMeshProUGUI RacesLostDisplay;
    public GameObject InputField;
    public GameObject StatsPanel;
    private bool DisplayChange = false;

    private void Start()
    {
        InputField.SetActive(false);
        NameDisplay.text = UniversalSave.PlayerName;
    }

    private void Update()
    {
        if(DisplayChange)
        {
            DisplayChange = false;
            NameDisplay.text = UniversalSave.PlayerName;
            RacesWonDisplay.text = UniversalSave.RacesWon.ToString();
            RacesLostDisplay.text = UniversalSave.RacesLost.ToString();
        }
    }

    public void ChangeName()
    {
        UniversalSave.PlayerName = NewName.text;
        UniversalSave.Saving = true;
        DisplayChange = true;
        InputField.SetActive(false);
    }

    public void EditName()
    {
        InputField.SetActive(true);
    }

    public void SwitchOffStats()
    {
        StatsPanel.SetActive(false);
    }
}
