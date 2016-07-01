using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour {

    public Transform leftLimit;
    public Transform rightLimit;
    public float patrolSpeed = 1;
    float hmax = 0;
    float hmin = 0;
    float offset = 0;
    Vector3 direction = Vector3.left;

    // Use this for initialization
    void Start () {
        offset = GetComponent<BoxCollider2D>().size.x / 4;
        hmax = rightLimit.position.x;
        hmin = leftLimit.position.x;
        float hpos = Random.Range(hmin + offset, hmax - offset);
        transform.position = new Vector2(hpos, transform.position.y);
        direction *= patrolSpeed;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        if (pos.x > hmin && pos.x < hmax)
        {            
            SpriteRenderer renderer = GetComponent<SpriteRenderer>();            
            if (pos.x + offset > hmax )
            {
                direction *= -1;
                renderer.flipX = false;
            }
            if (pos.x - offset < hmin)
            {
                direction *= -1;
                renderer.flipX = true;
            }
            transform.Translate(direction * Time.deltaTime);
        }
	}
}
