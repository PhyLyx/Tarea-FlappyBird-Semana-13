using UnityEngine;
using UnityEngine.SceneManagement;
public class Continuar : MonoBehaviour
{
    public void ContinuarPantalla()
    {
        SceneManager.LoadScene("Elegir Niveles");
    }

}
