using UnityEngine;

public class UniversalSave : MonoBehaviour
{
    public static int LapCounts;
    public static int OpponentsCount;
    public static int CreditAmount;
    public static bool Saving = false;
    public static string PlayerName = "player";
    public static int RacesWon = 0;
    public static int RacesLost = 0;

    private void Start()
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
        PlayerPrefs.SetString("PlayName", PlayerName);
        PlayerPrefs.SetInt("WonRaces", RacesWon);
        PlayerPrefs.SetInt("LostRaces", RacesLost);
    }

    public void LoadStats()
    {
        CreditAmount = PlayerPrefs.GetInt("MyCredits");
        PlayerName = PlayerPrefs.GetString("PlayName");
        RacesWon = PlayerPrefs.GetInt("WonRaces");
        RacesLost = PlayerPrefs.GetInt("LostRaces");
    }
}
