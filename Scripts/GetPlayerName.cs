/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetPlayerName : MonoBehaviour 
{
    public Text playerN;

	void Start () 
    {
        //Debug.Log(PlayerName.playerNamelvl);
        playerN.text = PlayerName.playerNamelvl;
	}
}
