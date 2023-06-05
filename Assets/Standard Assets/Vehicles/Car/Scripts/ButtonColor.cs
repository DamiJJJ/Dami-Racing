using UnityEngine;
using UnityEngine.UI;

public class ButtonColor : MonoBehaviour
{
    public Color32 CarColor;
    public static bool Change = false;

    private void Awake()
    {
        CarColor = this.gameObject.GetComponent<Image>().color;
    }
    public void SetColor()
    {
        SaveScript.PreviewCarColor = CarColor;
        Change = true;
    }
}
