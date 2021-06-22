using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Behaviour : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime); 

        if(transform.position.y > 10f){
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Enimy"){
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        else if(collision.gameObject.tag == "Respawn"){
            collision.transform.position += new Vector3(transform.position.x, 9);
        }

    }
}
