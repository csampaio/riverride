using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    private static GameManager _instance;
    public Text score;
    public GameObject gameOverObj;
    private int playerScore = 0;
    
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject obj = new GameObject("GameManager");
                obj.AddComponent<GameManager>();
            }

            return _instance;
        }
    }


    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        _instance = this;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverObj.SetActive(true);
    }

    public void Play()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddScore(int value)
    {
        playerScore += value;
        score.text = "SCORE: " + playerScore.ToString("000000");
    }
}
