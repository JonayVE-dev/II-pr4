using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer3Respuesta2 : MonoBehaviour
{
    Notificador3 notificador;
    GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        notificador = GameObject.Find("blue_cube").GetComponent<Notificador3>();
        notificador.onGetCloseToCylinder += LookAtTarget;
        target = GameObject.FindWithTag("target");
    }

    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 10, Color.red, 1);
    }


    void LookAtTarget()
    {
        transform.LookAt(target.transform);
    }
}
