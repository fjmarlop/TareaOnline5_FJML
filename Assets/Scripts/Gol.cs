using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour
{
    public bool isporteriaJugador1;
    public GameObject gameManager;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bola")){

            if (isporteriaJugador1){
                gameManager.GetComponent<GameManager>().jugador2Marca();
            }else{
                gameManager.GetComponent<GameManager>().jugador1Marca();
            }
        }
    }
}
