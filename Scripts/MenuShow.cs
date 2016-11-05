/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;

public class MenuShow : MonoBehaviour {

    public GameObject menuParent;
    public GameObject fader;
	void Start ()
    {
        menuParent.SetActive(true);
        fader.SetActive(true);
	}
	void Update ()
    {
	
	}
}
