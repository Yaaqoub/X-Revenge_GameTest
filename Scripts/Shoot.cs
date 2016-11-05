/* YAAQOUB SEMLALI ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 */
using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour 
{
    public GameObject bullet;
    public GameObject bulletHole;
    public Rigidbody doorLock;
    public GameObject enemy1;
    public AudioClip clockSound;
    public AudioClip clockDropping;

    public static bool lockState = false;

    public float delayTime = 8f;

    private AudioSource shooot;
    
    private float counter = 0;

    public EnemyHealth enemyHealth;
    public EnemyHealth enemyHealth2;
    public EnemyHealthSetAlarm enemyHealthSetAlarm;
    public EnemyHealthRobot enemyHealthRobot;

    public EnemyHealth[] enemyHealthAfterTrigger; 
    public EnemyHealth[] enemyHealthAfterTriggerForRobot;
    public EnemyHealthRobot[] enemyHealthRobot2; 

    public int attackDamage = 10;               // Attack Dmg per attack.

    int shootableMask;
	void Awake ()
    {
        shootableMask = LayerMask.GetMask("Shootable");
    }

    void Start () 
    {
        shooot = GetComponent<AudioSource>();
	}
	
	void FixedUpdate ()
    {
        //Debug.Log(enemyHealth2.currentHealth);
        if (Input.GetButton("Fire1") && counter > delayTime && !PlayerHealth.isDead)
        {
            Object bulletInst = Instantiate(bullet, transform.position, transform.rotation);
            bulletInst.name = "Bullet_exp";

            shooot.Play();
            counter = 0;

            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);

            /*if (Physics.Raycast(ray, out hit, 100f, shootableMask))
            {
                EnemyHealth enemyHealth = hit.collider.GetComponent<EnemyHealth>();

                if (enemyHealth != null)
                {
                    Debug.Log("U are hitting that");
                    //AttackE2();     
                }
            }*/

            if (Physics.Raycast(ray, out hit, 100f))
            {
                //Instantiate(bulletHole, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
                if (hit.transform.name == "DoorLock")
                {
                    AudioSource.PlayClipAtPoint(clockSound, transform.position);
                    doorLock.isKinematic = false;
                    lockState = true;
                    AudioSource.PlayClipAtPoint(clockDropping, transform.position);
                }
                if(hit.transform.name == "Enemy1")
                {
                    AttackE1();
                }

                if (hit.transform.name == "Enemy2")
                    AttackE2();
                if (hit.transform.name == "Enemy3")
                    AttackE3();
                if (hit.transform.name == "Enemy4")
                    AttackE4();
                if (hit.transform.name == "Enemy5")
                    AttackE5();
                if (hit.transform.name == "Enemy6")
                    AttackE6();
                if (hit.transform.name == "Enemy7")
                    AttackE7();
                if (hit.transform.name == "Enemy8")
                    AttackE8();
                if (hit.transform.name == "Robot2")
                    AttackR1();
                if (hit.transform.name == "Robot3")
                    AttackR2();

                if (hit.transform.name == "Enemy2_SetAlarm")
                {
                    AttackE2_SetAlarm();
                }
                if (hit.transform.name == "Robot1")
                {
                    AttackE2Robot();
                }
            }
        }

        counter += Time.deltaTime;
	}

    void AttackE1()
    {
        if (enemyHealth.currentHealth > 0)
            enemyHealth.TakeDamage(attackDamage + 10);
    }
    void AttackE2()
    {
        if (enemyHealthAfterTrigger[0].currentHealth > 0)
            enemyHealthAfterTrigger[0].TakeDamage(attackDamage + 10);
    }
    void AttackE3()
    {
        if (enemyHealthAfterTrigger[1].currentHealth > 0)
            enemyHealthAfterTrigger[1].TakeDamage(attackDamage + 10);
    }
    void AttackE4()
    {
        if (enemyHealthAfterTrigger[2].currentHealth > 0)
            enemyHealthAfterTrigger[2].TakeDamage(attackDamage + 10);
    }
    void AttackE5()
    {
        if (enemyHealthAfterTrigger[3].currentHealth > 0)
            enemyHealthAfterTrigger[3].TakeDamage(attackDamage + 10);
    }
    void AttackE6()
    {
        if (enemyHealthAfterTrigger[4].currentHealth > 0)
            enemyHealthAfterTrigger[4].TakeDamage(attackDamage + 10);
    }
    void AttackE7()
    {
        if (enemyHealthAfterTriggerForRobot[0].currentHealth > 0)
            enemyHealthAfterTriggerForRobot[0].TakeDamage(attackDamage + 10);
    }
    void AttackE8()
    {
        if (enemyHealthAfterTriggerForRobot[1].currentHealth > 0)
            enemyHealthAfterTriggerForRobot[1].TakeDamage(attackDamage + 10);
    }
    void AttackR1()
    {
        if (enemyHealthRobot2[0].currentHealth > 0)
            enemyHealthRobot2[0].TakeDamage(attackDamage + 10);
    }
    void AttackR2()
    {
        if (enemyHealthRobot2[1].currentHealth > 0)
            enemyHealthRobot2[1].TakeDamage(attackDamage + 10);
    }
    void AttackE2_SetAlarm()
    {
        if (enemyHealthSetAlarm.currentHealth > 0)
            enemyHealthSetAlarm.TakeDamage(attackDamage + 10);
    }
    void AttackE2Robot()
    {
        if (enemyHealthRobot.currentHealth > 0)
            enemyHealthRobot.TakeDamage(attackDamage + 10);
    }
}
