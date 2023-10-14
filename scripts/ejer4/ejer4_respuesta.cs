using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer4Respuesta : MonoBehaviour
{
    public int score;
    Notificador4 notificador;
    // Start is called before the first frame update
    void Start()
    {
        notificador = GameObject.Find("blue_cube").GetComponent<Notificador4>();
        notificador.onIncreseScore += UpdateScore;
        score = 0;
    }

    void UpdateScore(int points)
    {
        score += points;
        Debug.Log("Score: " + score);
    }
    
}
