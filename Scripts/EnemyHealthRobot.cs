/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;

public class EnemyHealthRobot : MonoBehaviour
{
    public int startingHealth = 300;            // The amount of health the enemy starts the game with.
    public int currentHealth;                   // The current health the enemy has.
    public float sinkSpeed = 2.5f;              // The speed at which the enemy sinks through the floor when dead.
    public int scoreValue = 1;                 // The amount added to the player's score when the enemy dies.
    public AudioClip deathClip;                 // The sound to play when the enemy dies.


    Animation anim;                              // Reference to the animator.
    AudioSource enemyAudio;                     // Reference to the audio source.
    CapsuleCollider capsuleCollider;            // Reference to the capsule collider.
    bool isDead;                                // Whether the enemy is dead.
    bool isSinking;                             // Whether the enemy has started sinking through the floor.

    EnemyMovementRobot enemyMove;
    NavMeshAgent nav;
    void Awake()
    {
        // Setting up the references.
        anim = GetComponent<Animation>();
        enemyAudio = GetComponent<AudioSource>();
        capsuleCollider = GetComponent<CapsuleCollider>();

        nav = GetComponent<NavMeshAgent>();
        enemyMove = GetComponent<EnemyMovementRobot>();
        // Setting the current health when the enemy first spawns.
        currentHealth = startingHealth;
    }

    public void TakeDamage(int amount)
    {
        // If the enemy is dead...
        if (isDead)
        {
            // ... no need to take damage so exit the function.
            return;
        }
            

        // Play the hurt sound effect.
        enemyAudio.Play();

        // Reduce the current health by the amount of damage sustained.
        currentHealth -= amount;

        // If the current health is less than or equal to zero...
        if (currentHealth <= 0)
        {
            // ... the enemy is dead.
            Death();
        }
    }


    void Death()
    {
        nav.enabled = false;
        enemyMove.enabled = false;
        // The enemy is dead.
        isDead = true;

        // Turn the collider into a trigger so shots can pass through it.
        capsuleCollider.isTrigger = true;
        
        // Tell the animator that the enemy is dead.
        anim.Play("idle", PlayMode.StopAll);
        
        // Change the audio clip of the audio source to the death clip and play it (this will stop the hurt clip playing).
        enemyAudio.clip = deathClip;
        enemyAudio.Play();

        ScoreManager.kills += scoreValue;
    }
}
