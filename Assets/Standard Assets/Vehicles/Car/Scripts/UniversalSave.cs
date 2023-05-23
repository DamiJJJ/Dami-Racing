using UnityEngine;

public class UniversalSave : MonoBehaviour
{
    public static int LapCounts;
    private void Start()
    {
        DontDestroyOnLoad(this);
    }
}
