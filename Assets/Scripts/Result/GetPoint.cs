using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetPoint : MonoBehaviour
{
    [SerializeField] private string input;
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        readPoint();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        
    }

    void readPoint()
    {
        if (input == "CritPerfect")
        {
            text.text = GManager.critPerfect.ToString();
        }
        else if (input == "Perfect")
        {
            text.text = GManager.perfect.ToString();
        }
        else if (input == "Great")
        {
            text.text = GManager.great.ToString();
        }
        else if (input == "Bad")
        {
            text.text = GManager.bad.ToString();
        }
        else if (input == "Miss")
        {
            text.text = GManager.miss.ToString();
        }
        else if (input == "Score")
        {
            text.text = GManager.score.ToString();
        }
        else if (input == "ScoreGrade")
        {
            if (GManager.score>=96000)//S/
            {
                text.color = new Color(255 / 255.0f, 254 / 255.0f, 0 / 255.0f);
                text.text = "S";
            }else if (GManager.score>=92000)//A/
            {
                text.color = new Color(255 / 255.0f, 0 / 255.0f, 0 / 255.0f);
                text.text = "A";
            }
            else if (GManager.score>=88000)//B/
            {
                text.color = new Color(255/255.0f, 192 / 255.0f, 0 / 255.0f);
                text.text = "B";
            }
            else if (GManager.score>=82000)//C/
            {
                text.color = new Color(18 / 255.0f, 0 / 255.0f, 255 / 255.0f);
                text.text = "C";
            }
            else if (GManager.score<82000)//F/
            {
                text.color = new Color(84 / 255.0f, 84 / 255.0f, 84 / 255.0f);
                text.text = "F";
            }
        }
        else if (input == "MaxCombo")
        {
            text.text = "Max Combo\n<size=80>" +GManager.maxCombo.ToString();
        }
        else if (input == "Yeah")
        {
            if (GManager.IsAllCritPerfect)
            {
                text.text = "All Critical Perfect!!!";
            }
            else if (GManager.IsAllPerfect)
            {
                text.text = "All Perfect!!!";
            }
            else if (GManager.IsFullCombo)
            {
                text.text = "Full Combo!!!";
            }
            else if(GManager.score>=82000)
            {
                text.text = "Clear!!!";
            }
            else if (GManager.score < 82000)
            {
                text.text = "Fail...";
            }
        }
        else if (input == "MusicName")
        {
            text.text = SceneManeger.playName;
        }
        else if (input == "Debug")
        {
            text.color = new Color(255 / 255.0f, 192 / 255.0f, 0 / 255.0f);
            text.text = "B";
        }
    }
}
