using UnityEngine;

public class UniversalSave : MonoBehaviour
{
    public static int LapCounts;
    public static int OpponentsCount;
    private void Start()
    {
        DontDestroyOnLoad(this);
    }
}
