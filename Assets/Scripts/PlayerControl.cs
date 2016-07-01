using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public float playerSpeed = 1;    
    public Transform topLeftLimit;
    public Transform bottonRightLimit;
    private float offsetX = 0;
    private float offsetY = 0;

    void Start()
    {
        offsetX = GetComponent<BoxCollider2D>().size.x / 2;
        offsetY = GetComponent<BoxCollider2D>().size.y / 2;
    }
	
	// Update is called once per frame
	void Update () {

        Vector2 playerPos = transform.position;
        bool onHScreen = playerPos.x - offsetX > topLeftLimit.position.x && playerPos.x + offsetX < bottonRightLimit.position.x;
        bool onVScreen = playerPos.y + offsetY < topLeftLimit.position.y && playerPos.y - offsetY > bottonRightLimit.position.y;
        if (onHScreen && onVScreen)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector2 mov;
            if (horizontal != 0 || vertical != 0)
            {
                mov = new Vector2(horizontal, vertical);
            }
            else
            {
                mov = Input.acceleration.normalized;
                mov.Scale(new Vector3(1, 1, 0));                
            }
            transform.Translate(mov * playerSpeed * Time.deltaTime);
        }
        else
        {
            Vector3 pos = Vector3.zero;
            if (!onHScreen)
            {
                pos = Vector3.right * playerSpeed * Time.deltaTime;
                pos = playerPos.x > 0 ? -pos : pos;
            }
            else
            {
                pos = Vector3.up * playerSpeed * Time.deltaTime;
                pos = playerPos.y > 0 ? -pos : pos;                
            }
            transform.Translate(pos);
        }
    }

}
