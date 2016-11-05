/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;

public class EnemyRobotTrigger : MonoBehaviour 
{
    public GameObject[] enemy;
    public EnemyHealth[] enemyIsDead;
    public EnemyHealthRobot[] enemyRobotIsDead;

    bool getInTheDoorRobot = false;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("U pass by");
        getInTheDoorRobot = true;
    }

    void Update()
    {
        if (getInTheDoorRobot == true)
        {
            enemy[0].SetActive(true);

            if (enemyIsDead[0].currentHealth <= 0)
            {
                enemy[1].SetActive(true);
            }
        }
        if(RobotWarning.warActive == true)
        {
            enemy[2].SetActive(true);
            enemy[3].SetActive(true);

            if (enemyRobotIsDead[0].currentHealth <= 0 && enemyRobotIsDead[1].currentHealth <= 0)
            {
                enemy[4].SetActive(true);
            }

        }
    }
}
