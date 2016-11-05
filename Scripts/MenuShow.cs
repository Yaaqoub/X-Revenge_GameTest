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
