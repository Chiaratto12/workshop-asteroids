using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoJogador : MonoBehaviour
{

    public Rigidbody2D meuRigidBody;
    public AudioSource audio;

    public float aceleracao = 1.0f;    
    public float VelocidadeAngular = 180.0f;
    public float velocidadeMaxima = 10.0f;
    
    public Rigidbody2D prefabProjetil;
    public float velocidadeProjetil = 10.0f;
    private float tempo;

    int x;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Rigidbody2D projetil = Instantiate(
                prefabProjetil, 
                meuRigidBody.position, 
                Quaternion.identity
            );
        
            audio.Play();
            tempo += Time.deltaTime;

            if(tempo > 3f) {
                Destroy(projetil.gameObject);
            }

                projetil.velocity = transform.up * velocidadeProjetil;
        }
    }

    void FixedUpdate() {
        if(Input.GetKey(KeyCode.UpArrow)){
            Vector3 direcao = transform.up * aceleracao;
            meuRigidBody.AddForce(direcao, ForceMode2D.Force);
        }

        if(Input.GetKey(KeyCode.LeftArrow)){
            meuRigidBody.rotation += VelocidadeAngular * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.RightArrow)){
            meuRigidBody.rotation -= VelocidadeAngular * Time.deltaTime;
        }

        if(meuRigidBody.velocity.magnitude > velocidadeMaxima){
            meuRigidBody.velocity = Vector2.ClampMagnitude(
                meuRigidBody.velocity,
                velocidadeMaxima
            );
        }
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
    }
}
