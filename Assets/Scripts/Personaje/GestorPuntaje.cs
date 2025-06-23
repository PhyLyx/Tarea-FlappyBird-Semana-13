using UnityEngine;

public class GestorPuntaje : MonoBehaviour
{
    public string nombreNivel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Puntos"))
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.AddScore(1);
                Debug.Log("Ganaste un punto");
            }
            else
            {
                Debug.LogError("GameManager no está en la escena o no está inicializado.");
            }
        }
    }

    public void GuardarRecord()
    {
        if (GameManager.Instance == null)
        {
            Debug.LogError("GameManager no está en la escena o no está inicializado.");
            return;
        }

        int puntajeActual = GameManager.Instance.GetScore();
        string claveRecord = "Record_" + nombreNivel;
        int recordAnterior = PlayerPrefs.GetInt(claveRecord, 0);

        if (puntajeActual > recordAnterior)
        {
            PlayerPrefs.SetInt(claveRecord, puntajeActual);
            PlayerPrefs.Save();
            Debug.Log("¡Nuevo récord guardado para " + nombreNivel + ": " + puntajeActual + " puntos!");
        }
        else
        {
            Debug.Log("No superaste el récord de " + recordAnterior + " puntos en " + nombreNivel);
        }
    }
}