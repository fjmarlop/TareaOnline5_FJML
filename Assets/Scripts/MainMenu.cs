using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Update(){
    if (Input.GetKeyDown(KeyCode.Escape)){
        Cerrar();
    }
}

    public void Cerrar(){
        Application.Quit();
    }
    public void PVsCom()
    {
        SceneManager.LoadScene("IAScene");
    }
    public void PVP(){
        SceneManager.LoadScene("PlayerVsPlayer");
    }
    public void Opciones(){
        SceneManager.LoadScene("OpcionesScreen");
    }
    public void Volver(){
        SceneManager.LoadScene("MainMenu");
    }
    public void campoHielo(){
        PlayerPrefs.SetInt("Campo",0);
        SceneManager.LoadScene("MainMenu");
    }
    public void campoCesped(){
        PlayerPrefs.SetInt("Campo",1);
        SceneManager.LoadScene("MainMenu");
    }
     public void campoParquet(){
        PlayerPrefs.SetInt("Campo",2);
        SceneManager.LoadScene("MainMenu");
    }
     public void campoEspacio(){
        PlayerPrefs.SetInt("Campo",3);
        SceneManager.LoadScene("MainMenu");
    }
}
