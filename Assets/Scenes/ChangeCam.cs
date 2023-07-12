using UnityEngine;

public class ChangeCam : MonoBehaviour
{
    public GameObject[] Cams;

    private void Start()
    {
        Cams[0].SetActive(true);
    }

    private void Update()
    {
        if (Input.GetButtonDown("ChangeCamera"))
        {
            Cams[SaveScript.CamID].SetActive(false);
            SaveScript.CamID++;
            if (SaveScript.CamID >= Cams.Length)
            {
                SaveScript.CamID = 0;
            }
            Cams[SaveScript.CamID].SetActive(true);
        }
    }
}
