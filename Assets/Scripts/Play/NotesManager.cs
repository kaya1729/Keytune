using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ChartData
{
    public string name;
    public int maxBlock;
    public int BPM;
    public int offset;
    public Note[] notes;

}
[Serializable]
public class Note
{
    public int type;
    public int num;
    public int block;
    public int LPB;
}

public class NotesManager : MonoBehaviour
{
    public static int maxScore;
    public int noteNum;
    private string songName;

    public List<int> LaneNum = new List<int>();
    public List<int> NoteType = new List<int>();
    public List<float> NotesTime = new List<float>();
    public List<GameObject> NotesObj = new List<GameObject>();

    [SerializeField] private float NotesSpeed;
    private float NotesTiming;
    [SerializeField] GameObject NoteObj;

    private void OnEnable()
    {
        noteNum = 0;
        maxScore = 0;
        NotesSpeed = SceneManeger.notesSpeed;
        NotesTiming = SceneManeger.notesTiming;
        songName = SceneManeger.playId+SceneManeger.playDif;
        Load(songName);
        //Load("test2");テスト用/
        
    }

    private void Load(string SongName)
    {
        string inputString = Resources.Load<TextAsset>("Charts/"+SongName).ToString();
        ChartData inputJson = JsonUtility.FromJson<ChartData>(inputString);

        noteNum = inputJson.notes.Length;
        maxScore = noteNum * 4;

        for(int i = 0; i < inputJson.notes.Length; i++)
        {
            float kankaku = 60 / (inputJson.BPM * (float)inputJson.notes[i].LPB);
            float beatSec = kankaku * (float)inputJson.notes[i].LPB;
            float time = (beatSec * inputJson.notes[i].num / (float)inputJson.notes[i].LPB) + inputJson.offset+ (NotesTiming/100f) + 8.0f;
            NotesTime.Add(time);
            LaneNum.Add(inputJson.notes[i].block);
            NoteType.Add(inputJson.notes[i].type);

            float z = NotesTime[i] * NotesSpeed;
            NotesObj.Add(Instantiate(NoteObj, new Vector3(inputJson.notes[i].block-2.5f, 0.3f, z), Quaternion.identity));
        }
    }
}
