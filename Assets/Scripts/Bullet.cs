using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if ( GetComponent<Rigidbody2D>().velocity.y < 0)
        {
            Destroy(this.gameObject);
        }
	}
}
