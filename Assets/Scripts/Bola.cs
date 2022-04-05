using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    private Vector2 starPos;
    
    
    void Start()
    {
        transform.position = starPos;
        launch();     
    }

    void Update()
    {
        transform.Rotate (new Vector3 (0,0,10));    
    }
    private void launch(){
        float x = Random.Range(0,2) == 0 ? -1 : 1;
        float y = Random.Range(0,2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
    
    public void Reset() {
        transform.position = starPos;
        rb.velocity = Vector2.zero;
        launch();
    }
    public void PararBola(){
         transform.position = starPos;
        rb.velocity = Vector2.zero;
    }
}