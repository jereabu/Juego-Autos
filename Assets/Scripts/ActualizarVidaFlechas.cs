using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualizarVidaFlechas : MonoBehaviour
{
    public GameObject player;
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
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "JugadorFlechas")
        {
            vidaFlechas -= 1;
            Debug.Log("Le diste");
        }
    }
}
