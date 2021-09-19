using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public ComportamentoJogador jogador;
    public MorreuMenu morreuMenu;
    public Pontuacao pontuacao;
    public Vida vida;
    //public Text text;
    public float tempoRespawn;
    public int vidas = 3;
    public float invunerabilidadeTempo;
    
    private void Start()
    {
        this.morreuMenu.gameObject.SetActive(false);
        //text = GetComponent<Text>();
    }

    private void Update()
    {
        //text.text = "Vida: x" + vidas;
    }

    public void JogadorMorreu(){
        this.vidas --;

        if(this.vidas <= 0){
            GameOver();
        }
        Invoke(nameof(Respawn), this.tempoRespawn);
    }

    private void Respawn(){
        this.jogador.transform.position = Vector3.zero;
        this.jogador.gameObject.layer = LayerMask.NameToLayer("Ignorar Colisões");
        this.jogador.gameObject.SetActive(true);
        Invoke(nameof(TurnOnCollisions), invunerabilidadeTempo);
    }

    private void TurnOnCollisions(){
        this.jogador.gameObject.layer = LayerMask.NameToLayer("Jogador");
    }

    private void GameOver(){
        /*this.vidas = 3;
        this.vida.gameObject.SetActive(false);
        this.pontuacao.gameObject.SetActive(false);
        this.jogador.gameObject.SetActive(false);
        this.morreuMenu.gameObject.SetActive(true);*/
        SceneManager.LoadScene("GameOver");
    }
}
