using UnityEngine;

public class UniversalSave : MonoBehaviour
{
    public static int LapCounts;
    public static int OpponentsCount;
    public static int CreditAmount;
    public static bool Saving = false;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        LoadStats();
    }

    private void Update()
    {
        if(Saving)
        {
            Saving = false;
            SaveStats();
        }
    }

    public void SaveStats()
    {
        PlayerPrefs.SetInt("MyCredits", CreditAmount);
    }

    public void LoadStats()
    {
        CreditAmount = PlayerPrefs.GetInt("MyCredits");
    }
}
