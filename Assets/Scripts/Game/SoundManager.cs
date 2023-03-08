using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    [SerializeField] AudioClip popSound;
    public AudioSource src;


    void Start()
    {
        src = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        src.PlayOneShot(popSound);
    }
}
