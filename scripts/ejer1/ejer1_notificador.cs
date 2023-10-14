using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notificador1 : MonoBehaviour
{
    public delegate void Hit();
    public event Hit onHit;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "red_cylinder" && onHit != null) {
            onHit();
        }
    }
}   
