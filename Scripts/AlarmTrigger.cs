/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;

public class AlarmTrigger : MonoBehaviour {
    public static bool alarmActive = false;

    void OnTriggerEnter(Collider other) {
        alarmActive = true;
    }

    void Update() {
        if (Input.GetButton("Fire1"))
            alarmActive = true;
    }
}
