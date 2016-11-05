using UnityEngine;
using System.Collections;

public class GameMenu1 : MonoBehaviour
{
    Renderer rend;

    public bool isQuit = false;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void OnMouseEnter()
    {
        rend.material.color = Color.red;
    }

    void OnMouseExit()
    {
        rend.material.color = Color.white;
    }

    void OnMouseUp()
    {
        if (isQuit == true)
        {
            Application.Quit();
        }
        else
        {
            Application.LoadLevel("Level01");
        }
    }
}
