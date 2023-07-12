using UnityEngine;
using Cinemachine;

public class LookBehind : MonoBehaviour
{
    // CinemachineComposer comp;
    // public CinemachineVirtualCamera vcam;
    // private Vector3 difference;

    public GameObject BehindCam;

    private void Start()
    {
        BehindCam.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetButtonDown("RearCamera"))
        {
            BehindCam.SetActive(true);
        }
        if (Input.GetButtonUp("RearCamera"))
        {
            BehindCam.SetActive(false);
        }
    }
}
