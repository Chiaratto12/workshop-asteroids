using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public GameManager gameManager;
    Text text; 

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = "Vidas: x" + gameManager.vidas;
    }
}
