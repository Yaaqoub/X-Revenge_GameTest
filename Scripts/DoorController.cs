/* YAAQOUB SEMLALI ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 */
using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour 
{
    public float doorOpenAngle = 90.0f;
    public float doorCloseAngle = 0.0f;
    public float doorAnimSpeed = 2.0f;

    public AudioClip[] doorSound;

    private Quaternion doorOpen = Quaternion.identity;
    private Quaternion doorClose = Quaternion.identity;
    private Transform playerTrans = null;

    private bool doorStatus; 
    private bool doorGo = false; 
    
    void Start()
    {
        doorStatus = false;

        doorOpen = Quaternion.Euler(0, -doorOpenAngle, 0);
        doorClose = Quaternion.Euler(0, doorCloseAngle, 0);
        
        playerTrans = GameObject.Find("MyPlayer").transform;
    }


    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F) && !doorGo)
        {
            //Distance between player and door
            if (Vector3.Distance(playerTrans.position, this.transform.position) < 1.5f)
            {
                if (doorStatus)
                { 
                    StartCoroutine(this.moveDoor(doorClose));
                    AudioSource.PlayClipAtPoint(doorSound[1], transform.position);
                }
                else
                { 
                    StartCoroutine(this.moveDoor(doorOpen));
                    AudioSource.PlayClipAtPoint(doorSound[0], transform.position);
                }
            }
        }
    }
    public IEnumerator moveDoor(Quaternion dest)
    {
        doorGo = true;
        //Check if close/open, if angle less 4 degree, or use another value more 0
        while (Quaternion.Angle(transform.localRotation, dest) > 4.0f)
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, dest, Time.deltaTime * doorAnimSpeed);
            yield return null;
        }
        //Change door status
        doorStatus = !doorStatus;
        doorGo = false;
         yield return null;
    }
}
