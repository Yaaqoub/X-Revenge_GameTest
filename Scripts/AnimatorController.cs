/* YAAQOUB SEMLALI ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 */
 
using UnityEngine;
using System.Collections;

public class AnimatorController : MonoBehaviour {
    public Animator anim;
    public AudioClip reload;
	
	void Update () {
        if (Input.GetButtonDown("Reload") && !PlayerHealth.isDead) {
            anim.SetBool("Charger", true);
            AudioSource.PlayClipAtPoint(reload, transform.position);
        }
        else {
            anim.SetBool("Charger", false);
        }

        if (Input.GetButton("Fire1") && !PlayerHealth.isDead) {
            anim.SetBool("Shoot", true);
        }
        else {
            anim.SetBool("Shoot", false);
        }
	}
}
