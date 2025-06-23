using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstaculo"))
        {
            GuardarRecordActual();
            SceneManager.LoadScene("Derrota");
        }
    }

    private void GuardarRecordActual()
    {
        if (GameManager.Instance == null) return;

        string nivelActual = SceneManager.GetActiveScene().name;
        string nombreNivel = "";

        switch (nivelActual)
        {
            case "Nivel 1":
                nombreNivel = "Nivel1";
                break;
            case "Nivel 2":
                nombreNivel = "Nivel2";
                break;
            case "Nivel 3":
                nombreNivel = "Nivel3";
                break;
            default:
                return; 
        }

        int puntajeActual = GameManager.Instance.GetScore();
        string claveRecord = "Record_" + nombreNivel;
        int recordAnterior = PlayerPrefs.GetInt(claveRecord, 0);

        if (puntajeActual > recordAnterior)
        {
            PlayerPrefs.SetInt(claveRecord, puntajeActual);
            PlayerPrefs.Save();
            Debug.Log("Nuevo record guardado para " + nombreNivel + ": " + puntajeActual + " puntos");
        }
        else
        {
            Debug.Log("No se supero el record de " + recordAnterior + " puntos en " + nombreNivel);
        }
    }
}