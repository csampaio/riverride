using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void GameOver()
    {
        Time.timeScale = 0;
    }

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
