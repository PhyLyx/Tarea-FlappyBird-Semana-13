using UnityEngine;
using UnityEngine.SceneManagement;

public class NivelesMejoresPuntajes : MonoBehaviour
{
    public string nombreDelNivel = "Nivel1"; 

    private void Start()
    {
        GuardarRecordDelNivel();
    }

    private void GuardarRecordDelNivel()
    {
        GestorPuntaje gestor = FindObjectOfType<GestorPuntaje>();

        if (gestor != null)
        {
            gestor.nombreNivel = nombreDelNivel;
            gestor.GuardarRecord();
        }
        else
        {
            Debug.LogError("No se encontró el GestorPuntaje en la escena");
        }
    }

    private void GuardarRecordAutomatico()
    {
        GestorPuntaje gestor = FindObjectOfType<GestorPuntaje>();

        if (gestor != null)
        {
            string escenaActual = SceneManager.GetActiveScene().name;

            if (escenaActual.Contains("Nivel 1") || escenaActual.Contains("Nivel1"))
                gestor.nombreNivel = "Nivel1";
            else if (escenaActual.Contains("Nivel 2") || escenaActual.Contains("Nivel2"))
                gestor.nombreNivel = "Nivel2";
            else if (escenaActual.Contains("Nivel 3") || escenaActual.Contains("Nivel3"))
                gestor.nombreNivel = "Nivel3";
            else
                gestor.nombreNivel = "NivelX";

            gestor.GuardarRecord();
        }
    }
}