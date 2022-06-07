using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorTiempo : MonoBehaviour
{
    public Text txt_TimeFloored;
    public GameObject WASD;
    public GameObject Flechas;
    public Text ganador;
    public GameObject cartel;
    int VidaWASD;
    int VidaFlechas;
    // Start is called before the first frame update
    void Start()
    {
        VidaWASD = GetComponent<ActualizarVidaWASD>().vidaWASD;
        VidaFlechas = GetComponent<ActualizarVidaFlechas>().vidaFlechas;
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;
        txt_TimeFloored.text = (90 - Mathf.Floor(time)).ToString();
        if (time > 90)
        {
            txt_TimeFloored.text = "Tiempo fuera!";
            cartel.SetActive(true);

            if (VidaWASD > VidaFlechas)
            {
                Destroy(Flechas);
                ganador.text = "Ganador: Rojo";
            }

            else if (VidaFlechas > VidaWASD)
            {
                Destroy(WASD);
                ganador.text = "Ganador: Azul";
            }

            else
            {
                ganador.text = "Empate";
            }
        }
    }
}
