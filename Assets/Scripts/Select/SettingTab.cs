using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SettingTab : MonoBehaviour
{
    [SerializeField] private int pos;
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pos == 0)
        {
            text.text = SceneManeger.settingName[SceneManeger.settingNum1];
        }else if (pos == 1)
        {
            text.text = SceneManeger.settingName[SceneManeger.settingNum2];
        }
        else if (pos == 2)
        {
            text.text = SceneManeger.settingName[SceneManeger.settingNum3];
        }else if (pos == 3)
        {
            if (SceneManeger.settingName[SceneManeger.settingNum2]=="Notes Speed")
            {
                text.text = SceneManeger.notesSpeed.ToString();
            }else if (SceneManeger.settingName[SceneManeger.settingNum2] == "Notes Timing")
            {
                text.text = SceneManeger.notesTiming.ToString();
            }
        }
    }
}
