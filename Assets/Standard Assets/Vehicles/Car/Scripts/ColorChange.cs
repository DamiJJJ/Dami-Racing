using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public bool MiniMapMarker = false;

    private void Start()
    {
        if(!MiniMapMarker)
        {
            var ThisRenderer = this.GetComponent<Renderer>();

            ThisRenderer.material.SetColor("_BaseColor", SaveScript.CarColor);
        }
        if(MiniMapMarker)
        {
            var ThisRenderer = this.GetComponent<Renderer>();

            ThisRenderer.material.SetColor("_UnlitColor", SaveScript.CarColor);
        }
    }
}
