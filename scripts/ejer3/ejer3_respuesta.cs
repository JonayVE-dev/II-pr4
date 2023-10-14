using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer3Respuesta1 : MonoBehaviour
{
    Notificador3 notificador;
    bool isJumping = false;
    public float jumpForce = 200;
    float lastCallTime = -1;

    // Start is called before the first frame update
    void Start()
    {
        notificador = GameObject.Find("blue_cube").GetComponent<Notificador3>();
        notificador.onGetCloseToCylinder += ChangeSphereColor;
        notificador.onGetCloseToCylinder += MakeSphereJump;
    }

    void Update()
    {
        if (transform.position.y <= 0.5f && isJumping)
        {
            isJumping = false;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
    void ChangeSphereColor()
    {
        if (Time.time - lastCallTime > 1)
        {
            lastCallTime = Time.time;
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
    }

    void MakeSphereJump()
    {
        if (!isJumping)
        {
            isJumping = true;
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
        }
    }
}
