
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor_Behaviour : MonoBehaviour
{
    public float speed;
    private float upSpeedEnimeTwo = 1;
    
    void Start()
    {
        StartCoroutine(TimeUp());
    }

    void Update()
    {
        transform.Translate(Vector3.down * speed * upSpeedEnimeTwo * Time.deltaTime); 

        if(transform.position.y < -10f & transform.position.y > -15f){
            Destroy(this.gameObject);
        }
    }

    IEnumerator TimeUp(){
        yield return new WaitForSeconds(3f);
        upSpeedEnimeTwo = 2;
    }

}
    
