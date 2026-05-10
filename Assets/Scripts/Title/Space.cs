using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Space : MonoBehaviour
{
    Image image;
    [SerializeField] Sprite sprite;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            image.sprite = sprite;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("終了");
            Application.Quit();
        }
    }
}
