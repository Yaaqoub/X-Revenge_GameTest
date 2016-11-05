/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;

public class Footstep : MonoBehaviour
{
    public AudioClip [] jumpingSound;

    private CharacterController myCharacterController;
    private AudioSource footStep;

    private int isHeJump = 0;
	void Start () 
    {
        myCharacterController = GetComponent<CharacterController>();
        footStep = GetComponent<AudioSource>();
	}
	
	void Update ()
    {
        if (myCharacterController.isGrounded == true && myCharacterController.velocity.magnitude > 2f && footStep.isPlaying == false)
        {
            footStep.volume = Random.Range(0.8f, 1);
            footStep.pitch = Random.Range(0.8f, 1.1f);
            footStep.Play();
        }

        if (Input.GetButtonDown("Jump"))
        {
            AudioSource.PlayClipAtPoint(jumpingSound[0], transform.position);
            isHeJump = 1;
        }

        if (isHeJump == 1 && myCharacterController.isGrounded)
        {
            AudioSource.PlayClipAtPoint(jumpingSound[1], transform.position);
            isHeJump = 0;
        }
	}
}
