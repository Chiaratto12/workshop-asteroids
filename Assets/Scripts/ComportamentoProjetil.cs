using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoProjetil : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip clip;
    public GameObject go;

    private float tempo;
    public float timer;

    void Start()
    {
        audio.Play();
    }

    void Update()
    {
        tempo += Time.deltaTime;

        if(tempo > timer) {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D outro)
    {
        Destroy(this.gameObject);
    }
}
