using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//楽曲リストを格納するクラス/
[Serializable]
public class SongsList
{
    public string id;
    public string name;
    public string composer;
    public int[] difficult;
}

[Serializable]
public class Data
{
    public SongsList[] list;
}
public class SceneManeger : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject setting;
    [SerializeField] private GameObject canvas2;
    [SerializeField] private PlayShorts playShorts;

    //設定を保存する変数/
    public static float notesSpeed = 8;
    public static float notesTiming = 0;

    public static int settingNum1 = -1;
    public static int settingNum2 = 0;
    public static int settingNum3 = 1;
    public static string[] settingName = { "Notes Speed", "Notes Timing" };

    //jsonファイルを読み込むための変数/
    public string inputText;
    public static Data inputJson;

    //楽曲リスト(配列)の何番目を選択しているかを保存する変数/
    public static int dif = 0;
    public static int song1 = -1;
    public static int song2 = 0;
    public static int song3 = 1;
    public int difMax;
    public int songMax;
    public static string playName;
    public static string playDif;
    public static string playId;

    private bool isSetting = false;
    private bool waitStart = false;

    void OnEnable()
    {
        Load();
        songMax = inputJson.list.Length;
        difMax = inputJson.list[song2].difficult.Length;
        song1 = -1;
        song2 = 0;
        song3 = 1;
        song1 = ArrayNum(song1, songMax);
        song2 = ArrayNum(song2, songMax);
        song3 = ArrayNum(song3, songMax);
        settingNum1 = ArrayNum(settingNum1, settingName.Length);
        settingNum2 = ArrayNum(settingNum2, settingName.Length);
        settingNum3 = ArrayNum(settingNum3, settingName.Length);
    }

    void Load()
    {
        inputText = Resources.Load<TextAsset>("MusicList").ToString();
        inputJson = JsonUtility.FromJson<Data>(inputText);
    }

    void Start()
    {
        //Debug.Log(inputJson.list.Length);
        playShorts.LoadShorts(inputJson.list[song2].id);
    }

    void Update()
    {
        if (waitStart == false)
        {
            if (isSetting == true)//設定画面を開いている/
            {
                if (Input.GetKeyDown(KeyCode.D))
                {
                    if (settingNum2 == 0)//ノーツスピード/
                    {
                        if (notesSpeed > 1f)
                        {
                            notesSpeed -= 0.5f;
                        }
                    }
                    if (settingNum2 == 1)//判定設定/
                    {
                        if (notesTiming > -10f)
                        {
                            notesTiming -= 1f;
                        }
                        //Debug.Log("ook");
                    }
                }

                if (Input.GetKeyDown(KeyCode.F))
                {
                    if (settingNum2 == 0)//ノーツスピード/
                    {
                        if (notesSpeed < 20f)
                        {
                            notesSpeed += 0.5f;
                        }
                    }
                    if (settingNum2 == 1)//判定設定/
                    {
                        if (notesTiming < 10f)
                        {
                            notesTiming += 1f;
                        }
                    }
                }


                if (Input.GetKeyDown(KeyCode.G))
                {
                    settingNum1 -= 1;
                    settingNum1 = ArrayNum(settingNum1, settingName.Length);
                    settingNum2 -= 1;
                    settingNum2 = ArrayNum(settingNum2, settingName.Length);
                    settingNum3 -= 1;
                    settingNum3 = ArrayNum(settingNum3, settingName.Length);
                }

                if (Input.GetKeyDown(KeyCode.H))
                {
                    settingNum1 += 1;
                    settingNum1 = ArrayNum(settingNum1, settingName.Length);
                    settingNum2 += 1;
                    settingNum2 = ArrayNum(settingNum2, settingName.Length);
                    settingNum3 += 1;
                    settingNum3 = ArrayNum(settingNum3, settingName.Length);
                }

            }
            if (isSetting == false)//設定画面を開いていない/
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    SceneManager.LoadScene("Title");
                }

                if (Input.GetKeyDown(KeyCode.D))
                {
                    if (dif > 0)
                    {
                        dif -= 1;
                        //dif = ArrayNum(dif, difMax);
                    }
                }

                if (Input.GetKeyDown(KeyCode.F))
                {
                    if (dif < 2)
                    {
                        dif += 1;
                        //dif = ArrayNum(dif, difMax);
                    }
                }


                if (Input.GetKeyDown(KeyCode.G))
                {
                    song1 -= 1;
                    song1 = ArrayNum(song1, songMax);
                    song2 -= 1;
                    song2 = ArrayNum(song2, songMax);
                    song3 -= 1;
                    song3 = ArrayNum(song3, songMax);
                    playShorts.LoadShorts(inputJson.list[song2].id);
                }

                if (Input.GetKeyDown(KeyCode.H))
                {
                    song1 += 1;
                    song1 = ArrayNum(song1, songMax);
                    song2 += 1;
                    song2 = ArrayNum(song2, songMax);
                    song3 += 1;
                    song3 = ArrayNum(song3, songMax);
                    playShorts.LoadShorts(inputJson.list[song2].id);
                }

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    waitStart = true;
                    setting.SetActive(false);
                    canvas2.SetActive(false);

                    playId = inputJson.list[song2].id;
                    playName = inputJson.list[song2].name;
                    if (dif == 0)
                    {
                        playDif = "Easy";
                    }
                    else if (dif == 1)
                    {
                        playDif = "Normal";
                    }
                    else if (dif == 2)
                    {
                        playDif = "Extra";
                    }
                    Invoke("MovePlay", 3.0f);
                }
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                isSetting = !isSetting;
                canvas.SetActive(!isSetting);
                setting.SetActive(isSetting);
            }
        }

    }

    int ArrayNum(int a, int length)
    {
        if (a < 0)
        {
            a = length - 1;
        }

        if (a > length - 1)
        {
            a = 0;
        }

        return a;
    }

    private void MovePlay()
    {
        SceneManager.LoadScene("Game");
    }
}
