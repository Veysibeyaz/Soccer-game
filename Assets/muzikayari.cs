using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzikayari : MonoBehaviour
{
    
    private AudioSource audioSource;
    public float muzikduzeyi;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume= muzikduzeyi;
    }
    public void Setvolume(float duzey){
        muzikduzeyi = duzey;
    }

}

