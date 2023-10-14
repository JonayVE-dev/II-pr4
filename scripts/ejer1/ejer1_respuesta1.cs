using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer1Respuesta2 : MonoBehaviour
{
    Notificador1 notificador;
    GameObject target;

    public float speed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        notificador = GameObject.Find("blue_cube").GetComponent<Notificador1>();
        notificador.onHit += Move;
        target = GameObject.Find("red_cylinder");
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Move()
    {
        Vector3 moveDirection = target.transform.position - transform.position;
        gameObject.GetComponent<Rigidbody>().MovePosition(transform.position + moveDirection.normalized * speed * Time.deltaTime);
    }
}
