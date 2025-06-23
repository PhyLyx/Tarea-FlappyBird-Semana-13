using UnityEngine;
using UnityEngine.SceneManagement;

public class ElegirNiveles : MonoBehaviour
{
    public void ElegirNivel1()
    {
        SceneManager.LoadScene("Nivel 1");
    }

    public void ElegirNivel2()
    {
        SceneManager.LoadScene("Nivel 2");
    }

    public void ElegirNivel3()
    {
        SceneManager.LoadScene("Nivel 3");
    }
}