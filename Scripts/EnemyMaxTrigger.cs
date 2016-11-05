using UnityEngine;
using System.Collections;

public class EnemyMaxTrigger : MonoBehaviour
{
    public GameObject[] enemy;
    public EnemyHealth[] enemyIsDead;

    bool getInTheDoorMax = false;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("U pass by");
        getInTheDoorMax = true;
    }

    void Update()
    {
        if (getInTheDoorMax == true)
        {
            enemy[0].SetActive(true);

            if (enemyIsDead[0].currentHealth <= 0)
            {
                enemy[1].SetActive(true);

                if (enemyIsDead[1].currentHealth <= 0)
                {
                    enemy[2].SetActive(true);

                    if (enemyIsDead[2].currentHealth <= 0)
                    {
                        enemy[3].SetActive(true);

                        if (enemyIsDead[3].currentHealth <= 0)
                        {
                            enemy[4].SetActive(true);
                        }
                    }
                }
            }     
        }
    }
}
