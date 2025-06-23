using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public float velocidad;

    public void Update()
    {
        MovimientoObstaculo();
    }

    private void MovimientoObstaculo()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - velocidad * Time.deltaTime);
    }

    public void Establecervelocidad(float vel)
    {
        velocidad = vel;
    }
}