using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorTiempo : MonoBehaviour
{
    public Text txt_TimeFloored;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;
        txt_TimeFloored.text = (90 - Mathf.Floor(time)).ToString();
        if (time > 90)
        {
            txt_TimeFloored.text = "Tiempo fuera!";
        }
    }
}
