using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.tag.Equals("bullet"))
        {
            Animator animator = GetComponent<Animator>();
            animator.SetTrigger("kaboon");
            GetComponentInChildren<GunController>().autoFire = false;
            Invoke("KillPlayer", 1);
        }
    }

    void KillPlayer()
    {
        GameManager.Instance.GameOver();
    }

    

}
