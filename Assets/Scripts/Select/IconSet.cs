using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconSet : MonoBehaviour
{
    [SerializeField] private int num;
    public Image image;
    public Sprite sprite;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        //アイコンに画像をセットする/
        
        if (num == 0)
        {
            sprite = Resources.Load<Sprite>("Images/" + SceneManeger.inputJson.list[SceneManeger.song1].id);
        }
        if (num == 1)
        {
            sprite = Resources.Load<Sprite>("Images/" + SceneManeger.inputJson.list[SceneManeger.song2].id);
        }

        if (num == 2)
        {
            sprite = Resources.Load<Sprite>("Images/" + SceneManeger.inputJson.list[SceneManeger.song3].id);
        }
        image.sprite = sprite;
        
    }

    // Update is called once per frame
    void Update()
    {
        //アイコンに画像をセットする/
        
        if (num == 0)
        {
            sprite = Resources.Load<Sprite>("Images/" + SceneManeger.inputJson.list[SceneManeger.song1].id);
        }
        if (num == 1)
        {
            sprite = Resources.Load<Sprite>("Images/" + SceneManeger.inputJson.list[SceneManeger.song2].id);
        }

        if (num == 2)
        {
            sprite = Resources.Load<Sprite>("Images/" + SceneManeger.inputJson.list[SceneManeger.song3].id);
        }
        image.sprite = sprite;
        
    }
}
