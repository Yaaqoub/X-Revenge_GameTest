/* YAAQOUB SEMLALI ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 */
using UnityEngine;
using System.Collections;

public class EnemyMovementMax : MonoBehaviour
{
    //public GameObject wayPoint;

    Transform player;                   // Reference to the player's position.
    //PlayerHealth playerHealth;        // Reference to the player's health.
    //EnemyHealth enemyHealth;          // Reference to this enemy's health.
    NavMeshAgent nav;                   // Reference to the nav mesh agent.

    private Animation anim;

    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //playerHealth = player.GetComponent<PlayerHealth>();
       // enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animation>();
    }

    void Start()
    {
        anim.Play("idle");
    }
    void Update()
    {
        // If the enemy and the player have health left...
        //if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        //{
            // ... set the destination of the nav mesh agent to the player.
        if(nav.enabled)
            nav.SetDestination(player.position);

        if(nav.enabled)
            if (nav.remainingDistance >1.8f && !PlayerHealth.isDead)
            {
                anim.Play("run");
                nav.acceleration = 8;
            }
            else
            {
                if (!PlayerHealth.isDead)
                {
                    //Rotate to player
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.position - transform.position), 3f * Time.deltaTime);

                    anim.Play("punch", PlayMode.StopAll);
                }
                else
                {
                    nav.acceleration = 0.5f;
                    //nav.SetDestination(wayPoint.transform.position);
                    anim.Play("walk");
                }
            }
            
        //}
        // Otherwise...
       // else
        //{
            // ... disable the nav mesh agent.
           // nav.enabled = false;
       // }
    }
}
