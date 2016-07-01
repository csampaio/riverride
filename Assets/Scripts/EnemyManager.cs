using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {

    public GameObject[] enemies;
    private int numEnemies = 0;
    private float nextEnemy = 0;
    public float maxSpanTime = 3;
    public float minSpanTime = 1;

    // Use this for initialization
    void Start () {
        numEnemies = enemies.Length;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextEnemy)
        {
            CreateEnemy();
        }
	
	}

    void CreateEnemy()
    {
        int enemyIndex = Random.Range(0, numEnemies);
        GameObject enemy = Instantiate(enemies[enemyIndex]);
        float patrolSpeed = Random.Range(1, 5);
        enemy.GetComponent<Patrol>().patrolSpeed = patrolSpeed;
        float delay = Random.Range(minSpanTime, maxSpanTime);
        nextEnemy = Time.time + delay;

    }
}
