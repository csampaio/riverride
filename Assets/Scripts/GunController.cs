using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {
    public float gunSpeed = 100;
    public float fireDelay = 1;
    public GameObject bulletType;
    public bool autoFire = true;
    private float nextFire = 0;


    // Update is called once per frame
    void Update () {
	    if (Time.time > nextFire && autoFire)
        {
            Fire();
            nextFire = Time.time + fireDelay;
        }
	}

    void Fire()
    {
        GameObject bullet = Instantiate(bulletType, transform.position, Quaternion.identity) as GameObject;
        Vector2 force = Vector2.up * gunSpeed;
        bullet.GetComponent<Rigidbody2D>().AddForce(force, ForceMode2D.Impulse);
    }
}
