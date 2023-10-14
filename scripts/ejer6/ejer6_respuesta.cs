using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ejer6Respuesta : MonoBehaviour
{
    public int score;
    Notificador6 notificador;
    TextMeshProUGUI scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        notificador = GameObject.Find("blue_cube").GetComponent<Notificador6>();
        scoreText = GameObject.Find("Canvas/score").GetComponent<TextMeshProUGUI>();
        notificador.onIncreseScoreText += UpdateScore;
        score = 0;
    }

    void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
    
}
