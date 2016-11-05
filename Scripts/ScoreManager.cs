/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int kills;        // The player's score.


    Text text;                      // Reference to the Text component.


    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();

        // Reset the score.
        kills = 0;
    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "Kills: " + kills;
    }
}
