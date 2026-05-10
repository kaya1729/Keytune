using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.fullScreen = true;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ScreenModeChange();
        }
        */
    }
    /*
    void ScreenModeChange()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }
    */
}
