using UnityEngine;
using UnityEngine.UI;

public class PreviewColor : MonoBehaviour
{
    private void Update()
    {
        if(ButtonColor.Change)
        {
            ButtonColor.Change = false;
            var ThisRenderer = this.GetComponent<Renderer>();

            ThisRenderer.material.SetColor("_BaseColor", SaveScript.PreviewCarColor);
        }
    }
}
