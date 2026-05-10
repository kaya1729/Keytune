using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Judgement : MonoBehaviour
{
    [SerializeField] private GameObject[] judgeAnime;
    [SerializeField] private NotesManager notesManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GManager.start)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (notesManager.LaneNum[0] == 0)
                {
                    Judge(ABS(GManager.gameTime - notesManager.NotesTime[0]), 0);
                }
                else if (notesManager.LaneNum[1] == 0)
                {
                    Judge(ABS(GManager.gameTime - notesManager.NotesTime[1]), 1);
                }
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (notesManager.LaneNum[0] == 1)
                {
                    Judge(ABS(GManager.gameTime - notesManager.NotesTime[0]), 0);
                }
                else if (notesManager.LaneNum[1] == 1)
                {
                    Judge(ABS(GManager.gameTime - notesManager.NotesTime[1]), 1);
                }
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                if (notesManager.LaneNum[0] == 2)
                {
                    Judge(ABS(GManager.gameTime - notesManager.NotesTime[0]), 0);
                }
                else if (notesManager.LaneNum[1] == 2)
                {
                    Judge(ABS(GManager.gameTime - notesManager.NotesTime[1]), 1);
                }
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                if (notesManager.LaneNum[0] == 3)
                {
                    Judge(ABS(GManager.gameTime - notesManager.NotesTime[0]), 0);
                }
                else if (notesManager.LaneNum[1] == 3)
                {
                    Judge(ABS(GManager.gameTime - notesManager.NotesTime[1]), 1);
                }
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                if (notesManager.LaneNum[0] == 4)
                {
                    Judge(ABS(GManager.gameTime - notesManager.NotesTime[0]),0);
                }
                else if (notesManager.LaneNum[1] == 4)
                {
                    Judge(ABS(GManager.gameTime - notesManager.NotesTime[1]), 1);
                }
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                if (notesManager.LaneNum[0] == 5)
                {
                    Judge(ABS(GManager.gameTime - notesManager.NotesTime[0]),0);
                }
                else if (notesManager.LaneNum[1] == 5)
                {
                    Judge(ABS(GManager.gameTime - notesManager.NotesTime[1]),1);
                }
            }

            if (GManager.gameTime > notesManager.NotesTime[0] + 0.23f)
            {
                //Debug.Log("Miss");
                JudgeAnime(4);
                GManager.combo = 0;
                GManager.miss++;
                DeleteData(0);
            }
        }
    }

    void Judge(float t,int number)
    {
        if (t <= 0.10f)
        {
            //Debug.Log("Critical Perfect");
            JudgeAnime(0);
            GManager.combo++;
            GManager.scoreData = GManager.scoreData + 4;
            GManager.critPerfect++;
            DeleteData(number);
        }
        else if (t<=0.15f)
        {
            //Debug.Log("Perfect");
            JudgeAnime(1);
            GManager.combo++;
            GManager.scoreData = GManager.scoreData + 3;
            GManager.perfect++;
            DeleteData(number);
        }
        else if (t<=0.20f)
        {
            //Debug.Log("Great");
            JudgeAnime(2);
            GManager.combo++;
            GManager.scoreData = GManager.scoreData + 2;
            GManager.great++;
            DeleteData(number);
        }
        else if (t<=0.23f)
        {
            //Debug.Log("Bad");
            JudgeAnime(3);
            GManager.combo = 0;
            GManager.scoreData = GManager.scoreData + 1;
            GManager.bad++;
            DeleteData(number);
        }
    }

    float ABS(float a)
    {
        if (a < 0)
        {
            a = -a;
        }
        return a;
    }

    void DeleteData(int removeNum)
    {
        notesManager.NotesTime.RemoveAt(removeNum);
        notesManager.LaneNum.RemoveAt(removeNum);
        notesManager.NoteType.RemoveAt(removeNum);
    }

    void JudgeAnime(int arrayNum)
    {
        Instantiate(judgeAnime[arrayNum], new Vector3(notesManager.LaneNum[0] - 2.5f, 1.0f, 0.15f), Quaternion.Euler(40,0,0));
    }
}
