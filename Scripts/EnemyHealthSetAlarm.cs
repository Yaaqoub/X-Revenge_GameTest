using UnityEngine;
using System.Collections;

public class EnemyHealthSetAlarm : MonoBehaviour 
{
    public int startingHealth = 100;            // The amount of health the enemy starts the game with.
    public int currentHealth;                   // The current health the enemy has.
    public int scoreValue = 1;                 // The amount added to the player's score when the enemy dies.
    public AudioClip deathClip;                 // The sound to play when the enemy dies.
    public AlarmSound alarmSoundMevement;

    Animation anim;                              // Reference to the animator.
    AudioSource enemyAudio;                     // Reference to the audio source.
    CapsuleCollider capsuleCollider;            // Reference to the capsule collider.
    bool isDead;                                // Whether the enemy is dead.

    NavMeshAgent nav;
    void Awake()
    {
        // Setting up the references.
        anim = GetComponent<Animation>();
        enemyAudio = GetComponent<AudioSource>();
        capsuleCollider = GetComponent<CapsuleCollider>();

        nav = GetComponent<NavMeshAgent>();
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
        alarmSoundMevement.enabled = false;
        // The enemy is dead.
        isDead = true;

        // Turn the collider into a trigger so shots can pass through it.
        capsuleCollider.isTrigger = true;

        // Tell the animator that the enemy is dead.
        anim.Play("death", PlayMode.StopAll);

        // Change the audio clip of the audio source to the death clip and play it (this will stop the hurt clip playing).
        enemyAudio.clip = deathClip;
        enemyAudio.Play();

        // Find and disable the Nav Mesh Agent.
        GetComponent<NavMeshAgent>().enabled = false;

        // Find the rigidbody component and make it kinematic (since we use Translate to sink the enemy).
        GetComponent<Rigidbody>().isKinematic = true;

        // Increase the score by the enemy's score value.
        ScoreManager.kills += scoreValue;

        //Destroy(gameObject, 2f);
    }
}
