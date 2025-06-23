using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonMenu : MonoBehaviour
{
    public void IniciarJuego(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
     public void Records(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
