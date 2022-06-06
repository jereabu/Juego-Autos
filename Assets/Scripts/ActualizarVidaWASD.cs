using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualizarVidaWASD : MonoBehaviour
{
    public GameObject player;
    int vidaWASD;
    // Start is called before the first frame update
    void Start()
    {
        vidaWASD = 100;       
    }

    // Update is called once per frame
    void Update()
    {
        if (vidaWASD < 10)
        {
            Destroy(player);
        }
    }

    void OnCollisionEnter(Collision col)
    {
         //Debug.Log("Le diste a " + col.gameObject.name);
        if (col.gameObject.name == "JugadorWASD")
        {
            vidaWASD -= 10;
            Debug.Log("Le diste");
        }
    }
}
