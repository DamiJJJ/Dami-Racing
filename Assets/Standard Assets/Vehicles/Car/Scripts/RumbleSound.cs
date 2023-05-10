using UnityEngine;

public class RumbleSound : MonoBehaviour
{
    private AudioSource Player;
    private bool Rumbling = false;

    private void Start()
    {
        Player = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(SaveScript.Rumble1 || SaveScript.Rumble2)
        {
            if(!Rumbling)
            {
                Rumbling = true;
                Player.Play();
            }
        }
        else
        {
            Player.Stop();
            Rumbling = false;
        }
    }
}
