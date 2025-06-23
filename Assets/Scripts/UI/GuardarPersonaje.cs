using UnityEngine;

public class GuardarPersonaje : MonoBehaviour
{
    public void SeleccionarPersonaje1()
    {
        PlayerPrefs.SetInt("PersonajeSeleccionado", 1);
    }

    public void SeleccionarPersonaje2()
    {
        PlayerPrefs.SetInt("PersonajeSeleccionado", 2);
    }

    public void SeleccionarPersonaje3()
    {
        PlayerPrefs.SetInt("PersonajeSeleccionado", 3);
    }
}