using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ComportamentoAsteroide : MonoBehaviour
{
    public Rigidbody2D meuRigidBody;
    public ComportamentoAsteroide go;
    public AudioSource audio;
    public AudioClip clip;

    public float velocidadeMaxima = 1.0f;
    public int quantosAsteroides = 3;
    public float vida = 30.0f;

    void Start()
    {
        //Vector2 direcao = Random.insideUnitCircle;
        //direcao *= velocidadeMaxima;
        //meuRigidBody.velocity = direcao;
    }

    void Update()
    {
        
    }

    public void SetTrajectory(Vector2 direcao){
        meuRigidBody.AddForce(direcao * this.velocidadeMaxima);

        Destroy(this.gameObject, this.vida);
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        if(this.gameObject.tag == "Asteroide"){
            for(int i = 0; i < quantosAsteroides; i++){
                ComportamentoAsteroide pequeno = Instantiate(go, outro.gameObject.transform.position, Quaternion.identity);
                pequeno.SetTrajectory(Random.insideUnitCircle.normalized);
            }
            AudioSource.PlayClipAtPoint(clip, transform.position);
            Destroy(this.gameObject);
            Pontuacao.pountuacao += 10;
            
        } 
        else if(this.gameObject.tag == "AsteroidePequeno"){
            AudioSource.PlayClipAtPoint(clip, transform.position);
            Destroy(this.gameObject);
            Pontuacao.pountuacao += 5;
        }
    }
}
