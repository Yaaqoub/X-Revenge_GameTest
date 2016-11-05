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
