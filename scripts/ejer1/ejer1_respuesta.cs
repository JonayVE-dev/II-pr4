using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer1Respuesta1 : MonoBehaviour
{
    Notificador1 notificador;
    // Start is called before the first frame update
    void Start()
    {
        notificador = GameObject.Find("blue_cube").GetComponent<Notificador1>();
        notificador.onHit += ChangeColor;
    }
    
    void ChangeColor()
    {
        GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
