using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bases : MonoBehaviour
{
    [SerializeField] private int num;
    private float alfa;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        touchCheck();
    }

    void touchCheck()
    {
        //rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, alfa);
        if (num == 0)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                rend.material.color = new Color(255f, 255f, 255f);
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                rend.material.color = new Color(0f, 0f, 0f);
            }
        }
        if (num == 1)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                rend.material.color = new Color(255f, 255f, 255f);
            }
            if (Input.GetKeyUp(KeyCode.F))
            {
                rend.material.color = new Color(0f, 0f, 0f);
            }
        }
        if (num == 2)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                rend.material.color = new Color(255f, 255f, 255f);
            }
            if (Input.GetKeyUp(KeyCode.G))
            {
                rend.material.color = new Color(0f, 0f, 0f);
            }
        }
        if (num == 3)
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                rend.material.color = new Color(255f, 255f, 255f);
            }
            if (Input.GetKeyUp(KeyCode.H))
            {
                rend.material.color = new Color(0f, 0f, 0f);
            }
        }
        if (num == 4)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                rend.material.color = new Color(255f, 255f, 255f);
            }
            if (Input.GetKeyUp(KeyCode.J))
            {
                rend.material.color = new Color(0f, 0f, 0f);
            }
        }
        if (num == 5)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                rend.material.color = new Color(255f, 255f, 255f);
            }
            if (Input.GetKeyUp(KeyCode.K))
            {
                rend.material.color = new Color(0f, 0f, 0f);
            }
        }
    }
}
