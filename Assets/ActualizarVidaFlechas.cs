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
        vidaFlechas = 100;       
    }

    // Update is called once per frame
    void Update()
    {
        if (vidaFlechas < 10)
        {
            Destroy(player);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ArmaWASD")
        {
            vidaFlechas -= 10;
            Debug.Log("Le diste");
        }
    }
}
