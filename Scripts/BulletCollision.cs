/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;

public class BulletCollision : MonoBehaviour {
    int basicBulletDmg = 1;
    int damage;

    void Start() {
        if (this.gameObject.name == "Bullet_exp") {
            damage = basicBulletDmg;
        }
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Enemy") {
            //Debug.Log(col.gameObject.name + " is an enemy! You did " + damage + " damage!!");

            Health enemyHealth = col.gameObject.GetComponent<Health>();
            //enemyHealth.ModifyHealth(-damage);
        }
        Destroy(this.gameObject);
    } 
}
