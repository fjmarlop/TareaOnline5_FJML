using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delantero : MonoBehaviour
{
    public bool isPlayer2;
    public float speed;
    public Rigidbody2D rb;

    private Vector2 starPos;

    void Start()
    {
        starPos = transform.position;
    }

    // Update is called once per frame
    
    void Update()
    {
                
        if(isPlayer2){
            rb.velocity = new Vector2 (Input.GetAxisRaw("Horizontal2") * speed,rb.velocity.y);
            rb.velocity = new Vector2 (rb.velocity.x, Input.GetAxisRaw("Vertical2") * speed);
        }else{
            rb.velocity = new Vector2 (Input.GetAxisRaw("Horizontal") * speed,rb.velocity.y);
            rb.velocity = new Vector2 (rb.velocity.x, Input.GetAxisRaw("Vertical") * speed);
        }
      
    }
     public void Reset() {
        transform.position = starPos;
        rb.velocity = Vector2.zero;
    }
    
}