using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    float timeToMeasureAgainst;
	void OnControllerColliderHit(ControllerColliderHit theCollision)
    {
        if(theCollision.gameObject.tag == "Enemy")
        {
            if (Time.time > timeToMeasureAgainst + 2)
            {
                Health myHealth = GetComponent<Health>();
                myHealth.ModifyHealth(-1);
                timeToMeasureAgainst = Time.time;
            }
        }
    }
}
