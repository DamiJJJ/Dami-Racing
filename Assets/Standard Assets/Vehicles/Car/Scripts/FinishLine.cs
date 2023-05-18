using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject Leaderboard;
    public string PlayerName;
    public static int PLayerFinishPosition;
    public static string PName;


    private void Start()
    {
        PName = PlayerName;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            SaveScript.FinishPositionID++;
            PLayerFinishPosition = SaveScript.FinishPositionID;
            SaveScript.RaceOver = true;
            Time.timeScale = 0.2f;
            Leaderboard.SetActive(true);
        }
    }
}
