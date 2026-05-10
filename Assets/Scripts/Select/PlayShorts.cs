using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayShorts : MonoBehaviour
{
    private AudioSource audioSource;
    private AudioClip shorts;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadShorts(string ShortName)
    {
        shorts = Resources.Load("Audio/Shorts/" + ShortName+"short") as AudioClip;
        audioSource.Stop();
        audioSource.clip = shorts;
        audioSource.Play();
        Debug.Log("ok");
    }
}
