using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bullet") || other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
