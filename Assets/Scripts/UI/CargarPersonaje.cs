using UnityEngine;

public class CargarPersonaje : MonoBehaviour
{
    public GameObject personaje1;
    public GameObject personaje2;
    public GameObject personaje3;

    void Start()
    {
        int seleccionado = PlayerPrefs.GetInt("PersonajeSeleccionado", 1);

        personaje1.SetActive(seleccionado == 1);
        personaje2.SetActive(seleccionado == 2);
        personaje3.SetActive(seleccionado == 3);
    }
}