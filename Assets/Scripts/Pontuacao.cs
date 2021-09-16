using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    public static int pountuacao = 0;
    Text score; 

    void Start()
    {
        score = GetComponent<Text>();
    }

    void Update()
    {
        score.text = "Pontuação: " + pountuacao;
    }
}
