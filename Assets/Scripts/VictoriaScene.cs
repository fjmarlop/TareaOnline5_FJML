using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoriaScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Invoke("LoadMainMenu", 6);
    }

    public void LoadMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
