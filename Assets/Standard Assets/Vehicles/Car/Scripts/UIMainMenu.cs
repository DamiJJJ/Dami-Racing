using UnityEngine;
using TMPro;

public class UIMainMenu : MonoBehaviour
{
    public TextMeshProUGUI CreditsText;
    private void Start()
    {
        CreditsText.text = UniversalSave.CreditAmount.ToString();
    }
}
