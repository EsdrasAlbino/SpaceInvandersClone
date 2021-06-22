using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aircraft_Behaviour : MonoBehaviour
{
    public float speed;
    void Start()
    {

    }

    void Update()
    {
        Move();
    }

    private void Move(){

        transform.Translate(Vector3.right * speed * Time.deltaTime); 

        if(transform.position.x > 10){
            speed *= -1;
        }else if(transform.position.x < -10){
            speed = Mathf.Abs(speed);
        }
    }


}
