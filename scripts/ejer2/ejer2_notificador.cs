using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notificador2 : MonoBehaviour
{
    public delegate void HitGroup1();
    public event HitGroup1 onHitGroup1;

    public delegate void HitNotGroup1();
    public event HitNotGroup1 onHitNotGroup1;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "plane") {
            return;
        }
        if (collision.gameObject.tag == "group1" && onHitGroup1 != null) {
            onHitGroup1();
        } else if (onHitNotGroup1 != null) {
            onHitNotGroup1();
        }
    }
}
