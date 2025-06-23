using UnityEngine;
using TMPro;

public class PantallaMejoresPuntajes : MonoBehaviour
{
    [SerializeField] private TMP_Text textoNivel1;
    [SerializeField] private TMP_Text textoNivel2;
    [SerializeField] private TMP_Text textoNivel3;

    void Start()
    {
        textoNivel1.text = "Nivel 1: " + PlayerPrefs.GetInt("Record_Nivel1", 0) + " puntos";
        textoNivel2.text = "Nivel 2: " + PlayerPrefs.GetInt("Record_Nivel2", 0) + " puntos";
        textoNivel3.text = "Nivel 3: " + PlayerPrefs.GetInt("Record_Nivel3", 0) + " puntos";
    }
    public void ResetearPuntajes()
    {
        if (PlayerPrefs.HasKey("Record_Nivel1") || PlayerPrefs.HasKey("Record_Nivel2") || PlayerPrefs.HasKey("Record_Nivel3"))
        {
            PlayerPrefs.DeleteKey("Record_Nivel1");
            PlayerPrefs.DeleteKey("Record_Nivel2");
            PlayerPrefs.DeleteKey("Record_Nivel3");
            PlayerPrefs.Save();

            textoNivel1.text = "Nivel 1: 0 puntos";
            textoNivel2.text = "Nivel 2: 0 puntos";
            textoNivel3.text = "Nivel 3: 0 puntos";
        }
    }
}