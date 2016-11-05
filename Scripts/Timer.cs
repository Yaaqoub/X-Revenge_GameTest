using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text counterText;
    public PlayerHealth playerHealth;

    public float seconds, minutes;
    public static string timeFin;

	void Start () 
    {
        counterText = GetComponent<Text>() as Text;
	}

	void Update () 
    {
        if (playerHealth.currentHealth <= 0)
            timeFin = counterText.text;
        else
        {
            minutes = (int)(Time.timeSinceLevelLoad / 60f);
            seconds = (int)(Time.timeSinceLevelLoad % 60f);
        }

        counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00");

       
	}
}
