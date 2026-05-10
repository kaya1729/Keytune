using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Difficult : MonoBehaviour
{
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text=GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = SceneManeger.inputJson.list[SceneManeger.song2].difficult[SceneManeger.dif].ToString();
        if (SceneManeger.dif == 0)
        {
            text.color = new Color(1.0f, 1.0f, 0);
        }
        if (SceneManeger.dif == 1)
        {
            text.color = new Color(1.0f, 127.0f / 255.0f, 0);
        }
        if (SceneManeger.dif == 2)
        {
            text.color = new Color(1.0f, 0, 0);
        }
    }
}
