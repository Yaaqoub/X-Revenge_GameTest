/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 300;                            // The amount of health the player starts the game with.
    public int currentHealth;                                   // The current health the player has.
    public Slider healthSlider;                                 // Reference to the UI's health bar.
    public Image damageImage;                                   // Reference to an image to flash on the screen on being hurt.
    public AudioClip deathClip;                                 // The audio clip to play when the player dies.
    public float flashSpeed = 5f;                               // The speed the damageImage will fade at.
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     // The colour the damageImage is set to, to flash.
    public static bool isDead;
    public Animator playerDeath;
    public AudioSource playerBreathing;
    public Animator gunAnimator;
    public Animator mainCameraAnimDeath;

    Animator anim;                                              // Reference to the Animator component.
    //AudioSource playerAudio;                                    // Reference to the AudioSource component.
    FPController playerMovement;                              // Reference to the player's movement.
    MouseController PlayerMovementMouse;    // Dyaliiii Mouse
    Footstep footStep;                      // Dyaliiii SoundStep
    AnimatorController animController;      // Dyaliiii Animation
    shoot gunShoot;                         // Dyaliiii GunShoot
                                                    // Whether the player is dead.
    bool damaged;                                               // True when the player gets damaged.

        
    void Awake()
    {
        // Setting up the references.
        anim = GetComponent<Animator>();
        //playerAudio = GetComponent<AudioSource>();
        playerMovement = GetComponent<FPController>();
        PlayerMovementMouse = GetComponent<MouseController>();  // Dyaliiii Mouse
        footStep = GetComponent<Footstep>();                    // Dyaliiii SoundStep
        animController = GetComponent<AnimatorController>();    // Dyalii Animation 
        gunShoot = GetComponent<shoot>();                       // Dyaliiii GunShoot

        // Set the initial health of the player.
        currentHealth = startingHealth;

        mainCameraAnimDeath.applyRootMotion = true;
    }


    void Update()
    {
        // If the player has just been damaged...
        if (damaged)
        {
            // ... set the colour of the damageImage to the flash colour.
            damageImage.color = flashColour;
        }
        // Otherwise...
        else
        {
            // ... transition the colour back to clear.
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }

        // Reset the damaged flag.
        damaged = false;
    }


    public void TakeDamage(int amount)
    {
        // Set the damaged flag so the screen will flash.
        damaged = true;

        // Reduce the current health by the damage amount.
        currentHealth -= amount;

        // Set the health bar's value to the current health.
        healthSlider.value = currentHealth;

        // Play the hurt sound effect.
        //playerAudio.Play();

        // If the player has lost all it's health and the death flag hasn't been set yet...
        if (currentHealth <= 0 && !isDead)
        {
            // ... it should die.
            Death();
        }
    }


    void Death()
    {
        // Set the death flag so this function won't be called again.
        isDead = true;

        
        mainCameraAnimDeath.applyRootMotion = false; //bach ikhdeem animation
        playerDeath.SetBool("Death", true); // Tell the animator that the player is dead.
        
        // Set the audiosource to play the death clip and play it (this will stop the hurt sound from playing).
        AudioSource.PlayClipAtPoint(deathClip, transform.position);

        // Turn off the movement and shooting scripts.
        playerMovement.enabled = false;
        PlayerMovementMouse.enabled = false;
        playerBreathing.Stop();
        gunAnimator.enabled = false;
    }
}
