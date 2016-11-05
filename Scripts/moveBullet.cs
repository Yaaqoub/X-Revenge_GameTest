/* YAAQOUB SEMLALI ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 */ 
using UnityEngine;
using System.Collections;

public class moveBullet : MonoBehaviour
{
    private float speed = 3f;

	void Start () 
    {
	
	}
	
	void Update ()
    {
        transform.Translate(0, 0, speed);

	}
}
