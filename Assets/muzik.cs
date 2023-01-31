using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ses : MonoBehaviour
{
    public AudioClip sound_fire;
    private AudioSource audioSource;

    void Start()
        {
        audioSource = GetComponent<AudioSource>();
        } 
    void Update()
    
    {
    if(Input.GetAxis("Fire1") > 0.0f)
    {
        audioSource.clip = sound_fire;
        audioSource.loop = false;
        audioSource.Play();
      
    }
    }
    }