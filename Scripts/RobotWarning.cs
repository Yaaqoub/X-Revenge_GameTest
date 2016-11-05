/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;

public class RobotWarning : MonoBehaviour 
{
    public static bool warActive = false;

    void OnTriggerEnter(Collider other)
    {
        warActive = true;
    }
}
