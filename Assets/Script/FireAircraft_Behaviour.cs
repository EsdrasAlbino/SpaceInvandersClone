using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAircraft_Behaviour : MonoBehaviour
{
    public float speed;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime); 

        if(transform.position.y < -10f){
            Destroy(this.gameObject);
        }
    }

}
