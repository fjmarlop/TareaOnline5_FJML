using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portero : MonoBehaviour
{
    public bool isPlayer2;
    public float speed;
    public Rigidbody2D rb;

    private float move;
    private Vector2 starPos;

   
    void Start()
    {
        starPos = transform.position;
    }
   
    void Update()
    {
       if (isPlayer2){
        move = Input.GetAxisRaw("Vertical2");
        rb.velocity = new Vector2(rb.velocity.x, move*speed);
       }else{
        move = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, move*speed);
       } 
       
    }
      public void Reset() {
        transform.position = starPos;
        rb.velocity = Vector2.zero;
    }
}