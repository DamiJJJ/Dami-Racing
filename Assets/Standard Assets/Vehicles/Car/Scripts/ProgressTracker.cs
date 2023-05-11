using System.Collections;
using UnityEngine;

public class ProgressTracker : MonoBehaviour
{
    public int CurrentWP = 0;
    public int ThisWPNumber;
    public int LastWPNumber;
    private AudioSource ThudSound;

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

    private void Update()
    {
        if(CurrentWP > LastWPNumber)
        {
            StartCoroutine(CheckDirection());
        }
        if(LastWPNumber > ThisWPNumber)
        {
            SaveScript.WrongWay = false;
        }
        if(LastWPNumber < ThisWPNumber)
        {
            SaveScript.WrongWay = true;
        }
    }

    IEnumerator CheckDirection()
    {
        yield return new WaitForSeconds(0.5f);
        ThisWPNumber = LastWPNumber;        
    }
}
