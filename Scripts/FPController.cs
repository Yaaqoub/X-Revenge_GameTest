/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;

public class FPController : MonoBehaviour
{
    public float walkSpeed = 10;
    public float jumpSpeed = 8;
    public float runSpeed = 15;
    public float slowSpeed = 5;

    private float gravity = 9.81f;
    private float speed;

    private Vector3 moveDirection = Vector3.zero;
    private Transform myTransform;
    private CharacterController myPlayer;

    void Start()
    {
        myTransform = transform;
        speed = walkSpeed;

        myPlayer = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        float horizontalMovementX = Input.GetAxis("Horizontal");    // Left - Right
        float verticalMovementY = Input.GetAxis("Vertical");        // Back - Forward

        if (airMovementControl() == true)
        {
            moveDirection.x = horizontalMovementX * speed;
            moveDirection.z = verticalMovementY * speed;
            moveDirection = myTransform.TransformDirection(moveDirection);

            if (Input.GetButtonDown("Jump"))
                moveDirection.y = jumpSpeed;
            

            if (Input.GetButton("Run"))
                speed = runSpeed;

            else if (Input.GetButton("Walk"))
                speed = slowSpeed;

            else
                speed = walkSpeed;
                        
        }
        myPlayer.Move(moveDirection * Time.deltaTime); //Player Movement
        moveDirection.y -= gravity * Time.deltaTime; //Apply gravity
    }

    bool airMovementControl() // if the player is in the Air or not
    {
        if (myPlayer.isGrounded)
            return true;
        
        else
            return false;
    }

}
