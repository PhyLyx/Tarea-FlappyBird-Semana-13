using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadScene(string Derrota)
    {
        SceneManager.LoadScene(Derrota);
    }

    public void AddScore(int amount)
    {
        score += amount;
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Derrota");
    }

    public int GetScore()
    {
        return score;
    }

    public void ResetGame()
    {
        score = 0;
        SceneManager.LoadScene("Menu Principal");
    }
}