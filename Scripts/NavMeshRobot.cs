using UnityEngine;
using System.Collections;

public class NavMeshRobot : MonoBehaviour 
{
    public Transform[] waypoints;

    private Animation anim;
    private int destPoint = 0;
    private NavMeshAgent agent;

	void Start () 
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animation>();

        agent.autoBraking = false;

        anim.Play("idle");

        GotoNextPoint();
        
	}

    void Update()
    {
        if (agent.remainingDistance < 0.5f)
        {
            GotoNextPoint();
        }
        anim.Play("walk");
    }

    void GotoNextPoint()
    {
        if (waypoints.Length ==0)
        {
            return;
        }

        agent.destination = waypoints[destPoint].position;

        destPoint = (destPoint + 1) % waypoints.Length;
    }
}
