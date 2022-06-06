using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActualizarVidaFlechas : MonoBehaviour
{
    public GameObject player;
    public Text ganador;
    public GameObject cartel;
    public GameObject timer;
    int vidaFlechas;
    // Start is called before the first frame update
    void Start()
    {
        vidaFlechas = 10;       
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
        }
    }
}