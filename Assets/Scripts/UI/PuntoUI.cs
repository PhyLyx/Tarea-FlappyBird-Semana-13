using UnityEngine;
using TMPro; 
public class Puntaje : MonoBehaviour
{
    [SerializeField] private TMP_Text textoPuntaje;

    void Start()
    {
        textoPuntaje.text = "Puntaje: " + GameManager.Instance.GetScore().ToString();
    }
}
