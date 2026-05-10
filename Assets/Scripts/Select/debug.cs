using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class debug : MonoBehaviour
{
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = SceneManeger.song1.ToString() + SceneManeger.song2.ToString() + SceneManeger.song3.ToString();
    }
}
