using UnityEngine;
using TMPro;

public class UIMainMenu : MonoBehaviour
{
    public TextMeshProUGUI CreditsText;
    public GameObject StatsPanel;
    private void Start()
    {
        CreditsText.text = UniversalSave.CreditAmount.ToString();
    }

    public void SwitchOnStats()
    {
        StatsPanel.SetActive(true);
    }
}
