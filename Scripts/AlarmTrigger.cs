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
