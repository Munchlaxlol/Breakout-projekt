using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AJ : MonoBehaviour
{
    AudioSource aud;
    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
        {
            aud.Play();
        }

    }
}
