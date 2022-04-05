using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
    public float speed;
    public bool isPortero;
    
    public GameObject balon;
    private Vector2 balonPos;

  
    void Update()
    {
        Move();
    }
    void Move()
    {
        balonPos = balon.transform.position;

        if (isPortero){
            
            if (transform.position.y >= balonPos.y){
                transform.position += new Vector3 (0, -speed * Time.deltaTime);
                
            }
            if (transform.position.y <= balonPos.y){
                transform.position += new Vector3 (0, speed * Time.deltaTime);
                
            }
        } else{
            if (transform.position.x > balonPos.x || transform.position.y > balonPos.y){
                transform.position += new Vector3 (-speed * Time.deltaTime, -speed * Time.deltaTime);
            }
            if (transform.position.x < balonPos.x || transform.position.y < balonPos.y){
                transform.position += new Vector3 (speed * Time.deltaTime, speed * Time.deltaTime);
            }
        }
            
    }
}
