using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirProjetil : MonoBehaviour
{
    private float tempo;
    public float timer;

    void Start()
    {
        
    }

    void Update()
    {
        tempo += Time.deltaTime;

        if(tempo > timer) {
            Destroy(this.gameObject);
        }
    }
}
