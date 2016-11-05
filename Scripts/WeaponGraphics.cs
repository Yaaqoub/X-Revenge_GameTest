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
