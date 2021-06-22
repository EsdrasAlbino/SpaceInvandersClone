using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float speed;
    private float rangeX = 9;
    public float lives = 5;

    public GameObject fire;
    float horizontalMove;

    void Start()
    {

    }

    void Update()
    {
       Move();
       Fire();
       CountLives();
    }

    void Move(){

        horizontalMove = Input.GetAxis("Horizontal") * speed;
        transform.position += new Vector3(horizontalMove,0,0) * Time.deltaTime * speed;

        if(transform.position.x > rangeX){
            transform.position = new Vector3(-rangeX, transform.position.y);
        } else if(transform.position.x < -rangeX){
            transform.position = new Vector3(rangeX, transform.position.y);
        }  
    }

    void Fire(){
                    
            if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(fire, transform.position, Quaternion.identity);
        }

    }

    	void CountLives() {
		if (lives <= 0) {
			Destroy(this.gameObject);
		}
	}

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Enimy" | other.gameObject.tag == "Fire") {
            Destroy(other.gameObject);
            lives--;
        }
    }
    
    
}
