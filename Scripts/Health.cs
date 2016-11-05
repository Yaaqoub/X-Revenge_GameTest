/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour 
{
    const int enemyHealth = 4;
    const int playerHealth = 28;
    
    public int maxHealth;

    public int MaxHealth
    {
        get { return maxHealth; }
    }

    public void SetMaxHealth(int setAmount)
    {
        maxHealth = setAmount;
    } 

    int currentHealth;

    public int CurrentHealth
    {
        get { return currentHealth; }
    }

    public void ModifyHealth(int modifyAmount)
    {
        currentHealth += modifyAmount;
        if (currentHealth < 1)
        {
            currentHealth = 0;
            
            if (this.gameObject.tag == "Enemy")
            {
                Destroy(this.gameObject);
            }
        }
        else if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        Debug.Log(this.gameObject.name + "HP: " + currentHealth + " / " + maxHealth);
    }

    void Start()
    {
        if (this.gameObject.name == "Enemy1")
        {
            SetMaxHealth(enemyHealth);
            ModifyHealth(enemyHealth);
        }
        else
        {
            SetMaxHealth(playerHealth);
            ModifyHealth(playerHealth);
        }
    }
}
