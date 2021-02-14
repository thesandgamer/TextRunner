using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Scr_AudioPlayer : MonoBehaviour
{

    [Header("Sons")]
    private AudioSource source;
    public AudioClip WinSound;
    public AudioClip DeathSound;
    public AudioClip MovePlatformSound;
    public AudioClip LanchTextSound;
    public AudioClip ErrorTextSound;


    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlayWinSound()
    {
        source.clip = WinSound;
        source.Play();
    }

    public void PlayDeathSound()
    {
        source.clip = DeathSound;
        source.Play();
    }

    public void PlayMovePlatformSound()
    {
        source.clip = MovePlatformSound;
        source.Play();
    }

    public void PlayLanchTextSound()
    {
        source.clip = LanchTextSound;
        source.Play();
    }
}
