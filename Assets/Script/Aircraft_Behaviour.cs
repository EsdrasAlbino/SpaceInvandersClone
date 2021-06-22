using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aircraft_Behaviour : MonoBehaviour
{
    public float speed;
    int teste;

    void Start()
    {
        StartCoroutine(TimeSpawn());
    }

    void Update()
    {
        
        Move();
        
    }

    private void Move(){
    
        if(teste == 1){
           // if(teste == 1){
             //   transform.position = new Vector3(transform.position.x, 3.35f);
            //}

            transform.Translate(Vector3.right * speed * Time.deltaTime); 

            if(transform.position.x > 10){
                speed *= -1;
            }else if(transform.position.x < -10){
                speed = Mathf.Abs(speed);
            }
        }
    }

    IEnumerator TimeSpawn(){
        while(true){
            yield return new WaitForSeconds(2);
            teste = 1;
            yield return new WaitForSeconds(2);
            teste = 0;
        }
}
}
