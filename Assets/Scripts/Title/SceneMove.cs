using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    private AudioSource audio;
    [SerializeField] AudioClip touchSE;
    private bool space = false;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (space == false)
            {
                audio.PlayOneShot(touchSE);
                Invoke("SceneChange", 2.0f);
                space = true;
            }
        }
    }

    void SceneChange()
    {
        SceneManager.LoadScene("Select");
    }
}
