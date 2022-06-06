using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActualizarVidaWASD : MonoBehaviour
{
    public GameObject player;
    public Text ganador;
    public GameObject cartel;
    public GameObject timer;
    int vidaWASD;
    // Start is called before the first frame update
    void Start()
    {
        vidaWASD = 10;       
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
        }
    }
}
