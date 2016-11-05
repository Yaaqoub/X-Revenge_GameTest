using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour
{
    string myName = "YAAQOUB";

    Health myHealth;

    void Awake()
    {
        myHealth = GetComponent<Health>();
    }
	void OnGUI()
    {
        GUI.Label(new Rect(5, 5, 100, 20), myName);
        GUI.Label(new Rect(5, 25, 120, 20), "Health: " + myHealth.CurrentHealth + " / " + myHealth.MaxHealth);
    }
}
