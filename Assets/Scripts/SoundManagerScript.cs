using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip cuttingSound;
    static AudioSource audioSource;
    void Start()
    {
        cuttingSound = Resources.Load<AudioClip>("Monster Bite");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound()
    {
        audioSource.PlayOneShot(cuttingSound);
    }
}
