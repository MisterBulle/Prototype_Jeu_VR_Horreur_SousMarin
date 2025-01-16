using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashaudio : MonoBehaviour
{

    public AudioSource audioSourceOn;
    public AudioSource audioSourceOff;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        audioSourceOff.Play();
    }
}
