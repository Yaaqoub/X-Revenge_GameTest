using UnityEngine;
using System.Collections;

public class AlarmSound : MonoBehaviour {
    public Transform alarm;
    public Transform enemy;
    public Transform player;
    public NavMeshAgent agent;
    public Transform[] points;
    public Animation anim;
    public Animation enemy1Anim;
    public EnemyMovementMax enemy1Movement;

    private int destPoint = 0;

    private AudioSource alarmSound;

    public static bool alarmWorking = false;

    void Start (){
        alarmSound = GetComponent<AudioSource>();
        //agent.autoBraking = false;
        anim.Play("idle");
        //GotoNextPoint();
    }

	void Update (){
        if (AlarmTrigger.alarmActive == false){
            //if (agent.remainingDistance < 2f)
                //GotoNextPoint();
            
            agent.acceleration = 1f;
            anim.Play("punch");
            enemy1Anim.Play("punch");
        }
        else{
            enemy1Movement.enabled = true;

            float enemyAlarmDistance = Vector3.Distance(alarm.position, enemy.position);

            //Debug.Log(enemyAlarmDistance);

            if (alarmWorking == false)
            {
                agent.acceleration = 8f;
                anim.Play("run");
                agent.SetDestination(alarm.transform.position);
                //agent.destination = alarm.position;
                if (enemyAlarmDistance < 2f){
                    if (!alarmSound.isPlaying && OnOffAlarm.aIsPressed == false){
                        alarmSound.Play();
                        alarmWorking = true;
                    }
                }
            }
            else{
                agent.SetDestination(player.transform.position);

                if (agent.remainingDistance > 1.8f && !PlayerHealth.isDead){
                    anim.Play("run");
                    agent.acceleration = 8;
                }
                else{
                    if (!PlayerHealth.isDead){
                        //Rotate to player
                        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.position - transform.position), 3f * Time.deltaTime);
                        anim.Play("punch", PlayMode.StopAll);
                    }   
                    else{
                        agent.acceleration = 1f;
                        //GotoNextPoint();
                    }
                }
            }
        }


	}

    /*void GotoNextPoint(){
        if (points.Length == 0){
            return;
        }

        agent.destination = points[destPoint].position;

        destPoint = (destPoint + 1) % points.Length;
    }*/
}
