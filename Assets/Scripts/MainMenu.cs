using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Pontuacao.pountuacao = 0;
    }

    public void QuitGame(){
        Debug.Log("Sair");
        Application.Quit();
    }

    public void Back(){
        SceneManager.LoadScene("Menu");
    }

    public void PlayAgain(){
        SceneManager.LoadScene("Jogo");
        Pontuacao.pountuacao = 0;
    }
}
