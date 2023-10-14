using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer2Respuesta1 : MonoBehaviour
{
    Notificador2 notificador;

    // Start is called before the first frame update
    void Start()
    {
        notificador = GameObject.Find("blue_cube").GetComponent<Notificador2>();
        notificador.onHitGroup1 += MakeSphereBigger;
    }

    void MakeSphereBigger()
    {
        gameObject.GetComponent<Transform>().localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }
}
