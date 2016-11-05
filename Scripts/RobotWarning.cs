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
