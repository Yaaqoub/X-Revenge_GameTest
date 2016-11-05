/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;

public class CrossHair : MonoBehaviour {
    public Texture crosshairTexture;
    
    private bool crosshairActivate;
    private Rect crosshairRect;
    
	void Start () {
        crosshairActivate = false;

        float crosshairSize = Screen.width * 0.1f;
        crosshairRect = new Rect(Screen.width / 1.92f - crosshairSize / 1.92f, Screen.height / 1.75f - crosshairSize / 1.52f, crosshairSize, crosshairSize);
	}
	
  void Update() {
      if (Input.GetKeyDown(KeyCode.C)) {
            crosshairActivate = !crosshairActivate;
      }
    }

	void OnGUI () {
        if (crosshairActivate == true)
        {
            GUI.DrawTexture(crosshairRect, crosshairTexture);
        }
	}
}
