using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActualizarVidaFlechas : MonoBehaviour
{
    public AudioClip crash;
    public GameObject player;
    public Text ganador;
    public GameObject cartel;
    public GameObject timer;
    public Text vida;
    public int vidaFlechas;
    AudioSource fuenteAudio;
    // Start is called before the first frame update
    void Start()
    {
        vidaFlechas = 10;  
        fuenteAudio = GetComponent<AudioSource>();     
    }

    // Update is called once per frame
    void Update()
    {
        if (vidaFlechas < 1)
        {
            Destroy(player);
            cartel.SetActive(true);
            ganador.text = "Ganador: Rojo";
            timer.SetActive(false);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "JugadorFlechas")
        {
            vidaFlechas--;
            Debug.Log("Le diste");
            fuenteAudio.clip = crash;
            fuenteAudio.Play();
            vida.text = "Azul: " + vidaFlechas * 10;
        }
    }
}