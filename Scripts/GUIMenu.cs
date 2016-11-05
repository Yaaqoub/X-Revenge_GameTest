using UnityEngine;
using System.Collections;

public class GUIMenu : MonoBehaviour
{
	void Update () 
    {
	    if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("Menu");
        }
	}
}
