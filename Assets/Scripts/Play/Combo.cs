using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Combo : MonoBehaviour
{
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "<size=60>"+GManager.combo.ToString();

        if (GManager.IsAllPerfect)
        {
            text.color = new Color(255 / 255.0f, 254 / 255.0f, 0 / 255.0f);
        }else if (GManager.IsFullCombo)
        {
            text.color = new Color(241 / 255.0f, 26 / 255.0f, 26 / 255.0f);
        }else if (!GManager.IsFullCombo)
        {
            text.color = new Color(255 / 255.0f, 255 / 255.0f, 255 / 255.0f);
        }
    }
}
