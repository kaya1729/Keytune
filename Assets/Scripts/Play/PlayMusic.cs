using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    private AudioSource audio;
    private AudioClip music;
    private bool test = true;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GManager.start&&test)
        {
            music = Resources.Load("Audio/"+SceneManeger.playId) as AudioClip;
            Invoke("ReadMusic",9.9f);
            test = false;
        }
    }

    void ReadMusic()
    {
        audio.PlayOneShot(music);
    }
}
