using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoAsteroidMenor : MonoBehaviour
{
    public Rigidbody2D meuRigidBody;
    public float velocidadeMaxima = 1.0f;
    public AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        Vector2 direcao = Random.insideUnitCircle;
        direcao *= velocidadeMaxima;
        meuRigidBody.velocity = direcao;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D outro) {
         if(outro.gameObject.tag == "Cima"){
            this.transform.position = new Vector3(meuRigidBody.position.x, -4.0f, 0.0f);
        }
        else if(outro.gameObject.tag == "Baixo"){
            this.transform.position = new Vector3(meuRigidBody.position.x, 4.0f, 0.0f);
        }
        else if(outro.gameObject.tag == "Direita"){
            this.transform.position = new Vector3(-9.3f, meuRigidBody.position.y, 0.0f);
        }
        else if(outro.gameObject.tag == "Esquerda"){
            this.transform.position = new Vector3(9.3f, meuRigidBody.position.y, 0.0f);
        }

        if(outro.gameObject.tag == "Player"){
            audio.Play();
            Destroy(outro.gameObject);
        }
        if(outro.gameObject.tag == "Projetil"){
            Pontuacao.pountuacao += 5;
            Destroy(this.gameObject);
        }
    }
}
