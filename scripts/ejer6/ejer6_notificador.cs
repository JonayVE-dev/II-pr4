using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notificador6 : MonoBehaviour
{
    public delegate void IncreseScoreText(int points);
    public event IncreseScoreText onIncreseScoreText;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "group1" && onIncreseScoreText != null) {
            onIncreseScoreText(5);
            Destroy(collision.gameObject);
            transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
        } else if (collision.gameObject.tag == "group2" && onIncreseScoreText != null) {
            onIncreseScoreText(10);
            Destroy(collision.gameObject);
            // aumentar tamaño del gameObject
            transform.localScale += new Vector3(0.4f, 0.4f, 0.4f);
        }
    }
}
