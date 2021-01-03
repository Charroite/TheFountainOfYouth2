using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioProxy : MonoBehaviour
{
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!source.isPlaying)
        { source.Play();}
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (source.isPlaying)
        { source.Stop(); }
    }
}
