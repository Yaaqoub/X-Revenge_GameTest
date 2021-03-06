/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;

public class EnemyManagerMax : MonoBehaviour 
{
    public PlayerHealth playerHealth;       
    public GameObject enemy;                
    public float spawnTime = 3f;            
    public Transform[] spawnPoints;         


    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
            InvokeRepeating("Spawn", 4, spawnTime);
    }
    void Spawn()
    {
        // If the player has no health left...
        if (playerHealth.currentHealth <= 0f)
        {
            // ... exit the function.
            return;
        }

        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Object enemyInst = Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        enemyInst.name = "Enemy2";
    }
}
