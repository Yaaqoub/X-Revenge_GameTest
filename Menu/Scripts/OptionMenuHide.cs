/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;

public class OptionMenuHide : MonoBehaviour
{
    public GameObject optionMenu;
	  void Awake () 
    {
        optionMenu.SetActive(false);
	  }
}
