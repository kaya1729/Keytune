using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DifText : MonoBehaviour
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
        if (SceneManeger.dif == 0)
        {
            text.color = new Color(1.0f, 1.0f, 0);
            text.text = "Easy";
        }
        if (SceneManeger.dif == 1)
        {
            text.color = new Color(1.0f, 127.0f / 255.0f, 0);
            text.text = "Normal";
        }
        if (SceneManeger.dif == 2)
        {
            text.color = new Color(1.0f, 0, 0);
            text.text = "Extra";
        }
    }
}
