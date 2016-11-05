using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour 
{
    int movementSpeed = 3;
    int rotationSpeed = 3;
    int attackRange = 1;

    float timeToMeasureAgainst;
    float detectionRange = 10;

    Transform playerTransform;
    Transform myTransform;

    private Animation anim;
    void Awake()
    {
        myTransform = transform;
    }

	void Start ()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animation>();
        anim.Play("idle");
	}
	
	void Update () 
    {
        float theDistance = Vector3.Distance(playerTransform.position, myTransform.position);

        if (theDistance < detectionRange)
        {
            if (theDistance < attackRange)
            {
                if (Time.time > timeToMeasureAgainst + 2)
                {
                    Health playerHealth = playerTransform.gameObject.GetComponent<Health>();
                    playerHealth.ModifyHealth(-1);
                    timeToMeasureAgainst = Time.time;
                }
            }

            if (theDistance > 0.75)
            {
                //Rotate To Player
                myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(playerTransform.position - myTransform.position), rotationSpeed * Time.deltaTime);

                //Move To Player
                myTransform.position += myTransform.forward * movementSpeed * Time.deltaTime;
            } 
        }
	}
}
