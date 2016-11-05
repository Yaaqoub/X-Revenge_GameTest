using UnityEngine;
using System.Collections;

public class DestroyBulletHole : MonoBehaviour {
	void Update () {
        Destroy(this.gameObject, 1);
	}
}
