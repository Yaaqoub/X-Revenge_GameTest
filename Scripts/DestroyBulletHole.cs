/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;

public class DestroyBulletHole : MonoBehaviour {
	void Update () {
        Destroy(this.gameObject, 1);
	}
}
