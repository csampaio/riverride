using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.tag.Equals("bullet"))
        {
            Destroy(this.gameObject);
        }
    }

}
