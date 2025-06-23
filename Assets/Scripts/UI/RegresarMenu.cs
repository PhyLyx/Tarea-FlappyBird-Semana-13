using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorBoton : MonoBehaviour
{
    public void CambiarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
