using UnityEngine;

public class ChangeCam : MonoBehaviour
{
    public GameObject[] Cams;
    private int CamID = 0;

    private void Start() {
        Cams[0].SetActive(true);
    }

    private void Update() {
        if(Input.GetButtonDown("ChangeCamera"))
        {
            Cams[CamID].SetActive(false);
            CamID++;
            if(CamID >= Cams.Length)
            {
                CamID = 0;
            }
            Cams[CamID].SetActive(true);
        }
    }
}
