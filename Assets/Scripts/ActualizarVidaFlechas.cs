using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActualizarVidaFlechas : MonoBehaviour
{
    public AudioClip crash;
    public GameObject player;
    public GameObject WASD;
    public Text ganador;
    public GameObject cartel;
    public GameObject timer;
    public GameObject corona;
    public Text vida;
    public int vidaFlechas;
    AudioSource fuenteAudio;
    int i = 0;
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
            corona.transform.position = new Vector3(WASD.transform.position.x, 1.3f, WASD.transform.position.z);
            corona.transform.localScale = new Vector3(0.2140924f, 0.2140924f, 0.2140924f);
            while (i < 5)
            {
                i++;
                Instantiate(corona);
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "AutoFlechas")
        {
            vidaFlechas--;
            Debug.Log("Le diste");
            fuenteAudio.clip = crash;
            fuenteAudio.Play();
            vida.text = "Azul: " + vidaFlechas * 10;
        }
    }
}