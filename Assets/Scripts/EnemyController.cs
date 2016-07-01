using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public int score = 100;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bullet"))
        {
            GameManager.Instance.AddScore(score);
            Animator animator = GetComponent<Animator>();
            animator.SetTrigger("kaboon");
            GetComponent<Patrol>().stopPatrol = true;
            GetComponent<BoxCollider2D>().enabled = false;
            Destroy(other.gameObject);            
            Invoke("KillEnemy", 3);
        }
    }

    public void KillEnemy()
    {
        Destroy(this.gameObject);
    }
}
