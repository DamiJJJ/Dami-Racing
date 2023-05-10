using UnityEngine;

public class ProgressTracker : MonoBehaviour
{
    public int CurrentWP = 0;
    private AudioSource ThudSound;
    private bool IsPlaying = false;

    private void Start()
    {
        ThudSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Barrier"))
        {
            if(!ThudSound.isPlaying)
            {
                ThudSound.Play();
            }
        }
    }
}
