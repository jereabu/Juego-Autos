using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActualizarVidaWASD : MonoBehaviour
{
    public AudioClip crash;
    public GameObject player;
    public Text ganador;
    public GameObject cartel;
    public GameObject timer;
    public Text vida;
    public int vidaWASD;
    AudioSource fuenteAudio;
    // Start is called before the first frame update
    void Start()
    {
        vidaWASD = 10;       
        fuenteAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vidaWASD < 1)
        {
            Destroy(player);
            cartel.SetActive(true);
            ganador.text = "Ganador: Azul";
            timer.SetActive(false);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "JugadorWASD")
        {
            vidaWASD--;
            Debug.Log("Le diste");
            fuenteAudio.clip = crash;
            fuenteAudio.Play();
            vida.text = "Rojo: " + vidaWASD * 10;
        }
    }
}
