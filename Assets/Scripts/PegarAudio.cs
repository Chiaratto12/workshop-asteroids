using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarAudio : MonoBehaviour
{
    public AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
