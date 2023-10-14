using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notificador4 : MonoBehaviour
{
    public delegate void IncreseScore(int points);
    public event IncreseScore onIncreseScore;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "group1" && onIncreseScore != null) {
            onIncreseScore(5);
            Destroy(collision.gameObject);
        } else if (collision.gameObject.tag == "group2 " && onIncreseScore != null) {
            onIncreseScore(10);
            Destroy(collision.gameObject);
        }
    }
}
