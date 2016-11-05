/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;

public class EnemyMovementRobot : MonoBehaviour
{
    public GameObject wayPoint;

    Transform player;               // Reference to the player's position.
    //PlayerHealth playerHealth;      // Reference to the player's health.
    //EnemyHealth enemyHealth;        // Reference to this enemy's health.
    NavMeshAgent nav;               // Reference to the nav mesh agent.
    EnemyAttackRobot enemyAttackScript;
    EnemyHealthRobot enemyHealth;

    private Animation anim;

    //shooting
    public GameObject bullet;
    public ParticleSystem muzzleFlashrobot;
    public AudioSource bulletSound;

    public float timeBetweenAttacks = 0.5f;
    float timer;
    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //playerHealth = player.GetComponent<PlayerHealth>();
       // enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animation>();
        enemyAttackScript = GetComponent<EnemyAttackRobot>();
        enemyHealth = GetComponent<EnemyHealthRobot>();
    }

    void Start()
    {
        anim.Play("idle");
    }
    void Update()
    {
        // If the enemy and the player have health left...
       // if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        //{
            // ... set the destination of the nav mesh agent to the player.
        //nav.SetDestination(player.position);

        nav.destination = player.position;

        if (nav.remainingDistance > 6f && !PlayerHealth.isDead)
        {
            anim.Play("run");
            nav.acceleration = 8;
        }
        else
        {
            
            if (!PlayerHealth.isDead)
            {
                timer += Time.deltaTime;

                //Rotate to player
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.position - transform.position), 3f * Time.deltaTime);

                
                // shooting 
                anim.Play("shoot");

                if (timer >= timeBetweenAttacks && enemyHealth.currentHealth > 0)
                    enemyAttackScript.Attack();

                if (muzzleFlashrobot.isPlaying)
                {
                    muzzleFlashrobot.Stop();
                }
                else
                {
                        bulletSound.Play();
                        muzzleFlashrobot.Play(); 
                    
                } 
            }
            else
            {
                nav.acceleration = 0.5f;
                nav.SetDestination(wayPoint.transform.position);
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
