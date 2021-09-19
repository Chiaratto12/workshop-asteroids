using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OndaDeAsteroides : MonoBehaviour
{
    public ComportamentoAsteroide asteroidePrefab;
    public float trajetoriaVariancia = 15.0f;
    public float ondaRate = 2.0f;
    public float ondaDistancia = 15.0f;
    public int ondaQuantidade = 1;

    void Start()
    {
        InvokeRepeating(nameof(Spawn), this.ondaRate, this.ondaRate);    
    }

    void Spawn(){
        for(int i = 0; i < this.ondaQuantidade; i++){
            Vector3 ondaDirecao = Random.insideUnitCircle.normalized * this.ondaDistancia;
            Vector3 ondaSpawn = this.transform.position + ondaDirecao;

            float variancia = Random.Range(-this.trajetoriaVariancia, this.trajetoriaVariancia);
            Quaternion rotacao = Quaternion.AngleAxis(variancia, Vector3.forward);

            ComportamentoAsteroide asteroide = Instantiate(this.asteroidePrefab, ondaSpawn, rotacao);
            asteroide.SetTrajectory(rotacao * -ondaDirecao);
        }
    }

    

}
