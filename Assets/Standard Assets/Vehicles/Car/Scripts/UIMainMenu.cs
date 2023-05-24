using UnityEngine;
using TMPro;

public class UIMainMenu : MonoBehaviour
{
    public TextMeshProUGUI CreditsText;
    public GameObject StatsPanel;
    private void Start()
    {
        Time.timeScale = 1;
        CreditsText.text = UniversalSave.CreditAmount.ToString();
    }

    public void SwitchOnStats()
    {
        StatsPanel.SetActive(true);
    }
}
