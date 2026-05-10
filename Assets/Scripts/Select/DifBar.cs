using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifBar : MonoBehaviour
{
    private Image Test;
    private int num=1;
    // Start is called before the first frame update
    void Start()
    {
        Test = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManeger.dif == 0)
        {
            Test.color = new Color(1.0f, 1.0f, 0);
        }
        if (SceneManeger.dif == 1)
        {
            Test.color = new Color(1.0f, 127.0f / 255.0f, 0);
        }
        if (SceneManeger.dif == 2)
        {
            Test.color = new Color(1.0f, 0, 0);
        }
        /*
        if (num == 4)
        {
            Test.color = new Color(0, 0, 0);
        }
        */
    }

    void numChange()
    {
        if (num < 1)
        {
            num = 4;
        }
        if (num > 4)
        {
            num = 1;
        }
    }
    void colorChange(int num)
    {
        if (num==1)
        {
            Test.color = new Color(1.0f,1.0f,0);
        }
        if (num==2)
        {
            Test.color = new Color(1.0f,127.0f/255.0f,0);
        }
        if (num==3)
        {
            Test.color = new Color(1.0f,0,0);
        }
        if (num==4)
        {
            Test.color = new Color(0,0,0);
        }
    }
}
