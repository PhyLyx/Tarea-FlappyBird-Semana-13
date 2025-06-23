using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float velocidadobstaculos;
    public float tiempoEntreObstaculos;
    public float desplazamientoAleatorio;

    public GameObject prefabObstaculo;
    public Transform puntoSpawn;



    public void Start()
    {
        StartCoroutine(SpawnObstaculos());
    }

    public IEnumerator SpawnObstaculos()
    {
        while (true)
        {
            float desplazamiento = Random.Range(-desplazamientoAleatorio, desplazamientoAleatorio);

            GameObject obstaculo = Instantiate(prefabObstaculo, puntoSpawn.position + new Vector3(0f, desplazamiento, 0f), Quaternion.identity);
            obstaculo.transform.GetComponent<Obstaculo>().Establecervelocidad(velocidadobstaculos);
            yield return new WaitForSeconds(tiempoEntreObstaculos);
        }
    }
}