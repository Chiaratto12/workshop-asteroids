using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoAsteroide : MonoBehaviour
{
    public Rigidbody2D meuRigidBody;
    public GameObject go;
    public AudioSource audio;

    public float velocidadeMaxima = 1.0f;
    public int quantosAsteroides = 3;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        Vector2 direcao = Random.insideUnitCircle;
        direcao *= velocidadeMaxima;
        meuRigidBody.velocity = direcao;
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
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
            for(int i = 0; i < quantosAsteroides; i++){
                    Instantiate(go, outro.gameObject.transform.position, Quaternion.identity);
                }
                Pontuacao.pountuacao += 10;
                Destroy(this.gameObject);
        }
    }
}
