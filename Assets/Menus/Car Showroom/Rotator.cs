using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float Speed = 5;
    private void Update()
    {
        this.transform.Rotate(0, Speed * Time.deltaTime, 0);
    }
}
