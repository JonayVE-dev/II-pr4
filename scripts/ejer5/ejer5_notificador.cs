using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notificador5 : MonoBehaviour
{
    public delegate void IncreseScoreText(int points);
    public event IncreseScoreText onIncreseScoreText;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "group1" && onIncreseScoreText != null) {
            onIncreseScoreText(5);
            Destroy(collision.gameObject);
        } else if (collision.gameObject.tag == "group2" && onIncreseScoreText != null) {
            onIncreseScoreText(10);
            Destroy(collision.gameObject);
        }
    }
}
