using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoJogador : MonoBehaviour
{

    public Rigidbody2D meuRigidBody;
    public float aceleracao = 1.0f;    
    public float VelocidadeAngular = 180.0f;
    public float velocidadeMaxima = 10.0f;
    
    public Rigidbody2D prefabProjetil;
    public float velocidadeProjetil = 10.0f;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Rigidbody2D projetil = Instantiate(
                prefabProjetil, 
                meuRigidBody.position, 
                Quaternion.identity
            );

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
        Destroy(gameObject);
    }
}
