using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reloj : MonoBehaviour
{
    public int tiempoInicial;
    public float escalaDeTiempo = 1;

    private Text myText;
    private float tiempoDelFrame = 0f;
    private float tiempoEnSegundos = 0f;
    // Start is called before the first frame update
    void Start()
    {
    myText = GetComponent<Text>();

    tiempoEnSegundos = tiempoInicial;
    ActualizarReloj(tiempoInicial);    
    }

    public void ActualizarReloj(float tiempoEnSegundos){
        
        int minutos = 0;
        int segundos = 0;
        string reloj;

        if (tiempoEnSegundos < 0) tiempoEnSegundos = 0;

        minutos = (int) tiempoEnSegundos / 60;
        segundos = (int) tiempoEnSegundos % 60;

        reloj = minutos.ToString("00") + ":" + segundos.ToString("00");

        myText.text = reloj;
    }
    
    void Update()
    {
        tiempoDelFrame = Time.deltaTime * escalaDeTiempo;
        tiempoEnSegundos += tiempoDelFrame;
        ActualizarReloj(tiempoEnSegundos);
    }
}
