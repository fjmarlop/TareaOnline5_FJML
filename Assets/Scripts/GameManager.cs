using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
 public GameObject balon;

 public GameObject portero1;
 public GameObject delantero1;
 public GameObject portero2;
 public GameObject delantero2;

 public GameObject porteriaJugador1;
 public GameObject porteriaJugador2;
 
 public Text golesJugador1;
 public Text golesJugador2;

private int jugador1GolesMarcados;
private int jugador2GolesMarcados;


public bool IAGame;

public int maxGoles = 5;

//cambio tipo de campo
public Sprite hielo;
public Sprite cesped;
public Sprite parquet;
public Sprite espacio;

public GameObject texturaCampo;
private SpriteRenderer spr;

//Golazo
public GameObject golazo;

void Start()
{
golazo.SetActive(false);
   
//campos
spr = texturaCampo.GetComponent<SpriteRenderer>();   
int campo = PlayerPrefs.GetInt("Campo");
switch (campo){
    case 0:
    spr.sprite = hielo;
    break;
    case 1:
    spr.sprite = cesped;
    break;
    case 2:
    spr.sprite = parquet;
    break;
    case 3:
    spr.sprite = espacio;
    break;
    default:
    spr.sprite = hielo;
    break;
}
}
void Update(){
    if (Input.GetKeyDown(KeyCode.Escape)){
        SceneManager.LoadScene("MainMenu");
    }
}
public void  victoria(){

    if(IAGame)
    {
        if (jugador1GolesMarcados >= maxGoles)
        {
        SceneManager.LoadScene("VictoriaIA");
        }
        if (jugador2GolesMarcados >= maxGoles)
        {
        SceneManager.LoadScene("VictoriaJugador");
        }
    } else
    {
        if (jugador1GolesMarcados >= maxGoles)
        {
        SceneManager.LoadScene("VictoriaJugador1");
        }
        if (jugador2GolesMarcados >= maxGoles)
        {
        SceneManager.LoadScene("VictoriaJugador2");        
        }
    }

    
}

public void jugador1Marca(){
    jugador1GolesMarcados++;
    golesJugador1.text = jugador1GolesMarcados.ToString();
    golazo.SetActive(true); 
    balon.GetComponent<Bola>().PararBola();
    victoria();
    Invoke("ResetPosition",1);
    
}
public void jugador2Marca(){
    jugador2GolesMarcados++;
    golesJugador2.text = jugador2GolesMarcados.ToString();
    golazo.SetActive(true);
    balon.GetComponent<Bola>().PararBola();
    victoria();
    Invoke("ResetPosition",1);
}

private void ResetPosition(){

        golazo.SetActive(false);

        if (IAGame){
            balon.GetComponent<Bola>().Reset();
            portero1.GetComponent<Portero>().Reset();
            delantero1.GetComponent<Delantero>().Reset();
        } else {
            balon.GetComponent<Bola>().Reset();
            portero1.GetComponent<Portero>().Reset();
            delantero1.GetComponent<Delantero>().Reset();
            portero2.GetComponent<Portero>().Reset();
            delantero2.GetComponent<Delantero>().Reset();
        }
}
}
