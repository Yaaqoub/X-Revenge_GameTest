/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;

public class NavMeshTest : MonoBehaviour 
{
    public Transform player;
    public Transform enemy;
    public Animation anim;

    NavMeshAgent agent;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        float enemyPlayerDistance = Vector3.Distance(player.position, enemy.position);

        if (enemyPlayerDistance > 4)
        {
            agent.destination = player.position;
            anim.Play("walk");
        }
        
    }
}
