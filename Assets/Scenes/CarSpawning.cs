using UnityEngine;

public class CarSpawning : MonoBehaviour
{
    public GameObject[] Cars;
    public Transform SpawnPoint;

    private void Start()
    {
        for (int i = 0; i < Cars.Length; i++)
        {
            if (i == SaveScript.CarID)
            {
                Instantiate(Cars[i], SpawnPoint.position, SpawnPoint.rotation);
            }
        }
    }
}
