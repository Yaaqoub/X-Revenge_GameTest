/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;

public class OnOffAlarm : MonoBehaviour
{
    public static bool aIsPressed = false;
    public AudioSource alarmSound;

    void OnTriggerStay(Collider other)
    {
        if (other.name == "MyPlayer")
        {
            aIsPressed = true;

            if (Input.GetButton("AlarmOff"))
                alarmSound.enabled = false;
        }
            
    }
}
