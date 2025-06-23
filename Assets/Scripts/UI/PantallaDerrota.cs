using UnityEngine;
using UnityEngine.SceneManagement;

public class UIDerrota : MonoBehaviour
{
    private void Start()
    {
        if (GameManager.Instance != null)
        {
            Debug.Log("Puntaje final: " + GameManager.Instance.GetScore());
        }
    }

    public void VolverAlMenu()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.ResetScore();
        }
        SceneManager.LoadScene("MenuPrincipal");
    }
}