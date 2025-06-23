using UnityEngine;

public class NivelesMejoresPuntajes : MonoBehaviour
{
    private void Start()
    {
        GestorPuntaje gestor = FindObjectOfType<GestorPuntaje>();

        gestor.nombreNivel = "Nivel1";
        gestor.GuardarRecord();
    }
}