using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplatSound : MonoBehaviour
{
    public AudioSource splatSound;
    // Start is called before the first frame update
    public void zombieKillSound()
    {
        splatSound.Play();
    }
}
