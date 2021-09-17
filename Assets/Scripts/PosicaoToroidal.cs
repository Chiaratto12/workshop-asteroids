using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicaoToroidal : MonoBehaviour
{
    const float Margem = 0.5f;
    public Rigidbody2D meuRigidbody;

    void Update()
    {
        Camera camera = GameplayCamera.instancia.minhaCamera;
        var maxX = camera.orthographicSize * camera.aspect;
        var maxY = camera.orthographicSize;

        float limiteEsquerda = -maxX;
        float limiteDireita = maxX;
        float limiteBaixo = -maxY;
        float limiteCima = maxY;
        
        Vector2 pos = meuRigidbody.position;
        if(pos.x < limiteEsquerda - Margem){
            pos.x = limiteEsquerda + Margem;
        }
        else if(pos.x < limiteDireita - Margem){
            pos.x = limiteDireita - Margem;
        }
        else if(pos.x < limiteCima- Margem){
            pos.x = limiteCima + Margem;
        }
        else if(pos.x < limiteBaixo- Margem){
            pos.x = limiteBaixo - Margem;
        }
        meuRigidbody.position = pos;
    }
}
