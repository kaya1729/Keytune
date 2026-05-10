using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GManager : MonoBehaviour
{
    [SerializeField] private GameObject ready;
    public static bool start = false;
    public bool isEndBool = false;
    public bool EndCheck = true;
    public static bool IsAllCritPerfect = true;
    public static bool IsAllPerfect = true;
    public static bool IsFullCombo = true;
    public static float gameTime = 0f;
    public static float spaceTime = 0f;
    public static int combo = 0;
    public static int score = 0;
    public static float scoreData = 0;
    public static int maxCombo = 0;
    public static int critPerfect = 0;
    public static int perfect = 0;
    public static int great = 0;
    public static int bad = 0;
    public static int miss = 0;
    [SerializeField] private NotesManager notesManager;
    // Start is called before the first frame update
    void Start()
    {
        gameTime = 0f;
        maxCombo = 0;
        start = false;
        isEndBool = false;
        EndCheck = true;
        IsAllCritPerfect = true;
        IsAllPerfect = true;
        IsFullCombo = true;
        gameTime = 0f;
        spaceTime = 0f;
        combo = 0;
        score = 0;
        scoreData = 0;
        //maxCombo = 0;
        critPerfect = 0;
        perfect = 0;
        great = 0;
        bad = 0;
        miss = 0;
        Instantiate(ready, new Vector3(0f, 2.5f, 0f), Quaternion.Euler(40, 0, 0));
        Invoke("GameStart", 2.0f);

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space)&&!start)
        {
            start = true;
            isEndBool = true;
            spaceTime = Time.time;
        }
        */
        gameTime = Time.time - spaceTime;

        score = (int)Mathf.Floor((scoreData / NotesManager.maxScore) * 100000);

        if (maxCombo < combo)
        {
            maxCombo = combo;
        }

        if (isEndBool)
        {
            if ((notesManager.LaneNum.Count == 0)&&EndCheck)
            {
                Invoke("isEnd", 3.0f);
                EndCheck = false;
            }
        }

        if (perfect + great + bad + miss > 0)
        {
            IsAllCritPerfect = false;
        }
        
        if (perfect + great + bad + miss > 0)
        {
            IsAllPerfect = false;
        }

        if (miss+bad > 0)
        {
            IsFullCombo = false;
        }
        //Debug.Log(notesManager.LaneNum.Count);
    }

    void GameStart()
    {
        spaceTime = Time.time;
        gameTime = Time.time - spaceTime;
        start = true;
        isEndBool = true;
        
    }

    void isEnd()
    {
        SceneManager.LoadScene("Result");
    }

}
