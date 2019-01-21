using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {
    // Use this for initialization
    AudioSource audio;
    void Start()
    {
        
        audio = GetComponent<AudioSource>();
    }
    void OnMouseDown()
    {
        audio.Play();
    }
}
