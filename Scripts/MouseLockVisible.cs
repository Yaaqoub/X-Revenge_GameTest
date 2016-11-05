/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MouseLockVisible : MonoBehaviour
{
    public Toggle pauseMenuTopCorner;

    void Start()
    {

    }
    void Update()
    {
        if (Time.timeScale == 1)
        {
            pauseMenuTopCorner.enabled = false;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            pauseMenuTopCorner.enabled = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
