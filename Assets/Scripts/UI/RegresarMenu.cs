using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorBoton : MonoBehaviour
{
    public void CambiarEscena(string nombreEscena)
    {
        if (nombreEscena.Contains("Nivel") && GameManager.Instance != null)
        {
            GameManager.Instance.ResetScore();
        }

        SceneManager.LoadScene(nombreEscena);
    }
}
