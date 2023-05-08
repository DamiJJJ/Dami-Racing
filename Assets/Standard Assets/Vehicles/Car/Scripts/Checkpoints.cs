using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    public bool CheckPoint1 = true;
    public bool CheckPoint2 = false;
    public bool CheckPoint3 = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(CheckPoint1 == true)
            {
                SaveScript.ThisCheckPoint1 = SaveScript.GameTime;
                SaveScript.CheckPointPass1 = true;
            }
            if(CheckPoint2 == true)
            {
                SaveScript.ThisCheckPoint2 = SaveScript.GameTime;
                SaveScript.CheckPointPass2 = true;
            }
            if(CheckPoint3 == true)
            {
                SaveScript.ThisCheckPoint3 = SaveScript.GameTime;
                SaveScript.CheckPointPass3 = true;
            }
        }
    }
}
