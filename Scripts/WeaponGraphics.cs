/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;

public class WeaponGraphics : MonoBehaviour 
{
    public ParticleSystem muzzleFlash;

    void Update()
    {
        if (Input.GetButton("Fire1"))
            muzzleFlash.Play();
        else
            muzzleFlash.Stop();
    }
        
}
