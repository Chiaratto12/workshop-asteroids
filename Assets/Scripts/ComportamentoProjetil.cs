using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoProjetil : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip clip;
    public GameObject go;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        clip = GetComponent<AudioClip>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "Asteroide"){
            Destroy(gameObject);
            Teste.audio.Play();
        }

        if (outro.gameObject.tag == "AsteroidePequeno"){
            Destroy(gameObject);
            Teste.audio.Play();
        }
    }
}
