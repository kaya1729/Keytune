using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    float notesSpeed = SceneManeger.notesSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GManager.start) {
            transform.position -= transform.forward * Time.deltaTime * notesSpeed; 
        }
    }
}
