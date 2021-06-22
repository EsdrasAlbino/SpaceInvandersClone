using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aircraft_Controller : MonoBehaviour
{
    [Header("Attributes")]
    public float fireOn;
    public bool onFire;
  
    public GameObject fireEnemy;

    void Start()
    {
        StartCoroutine(TimeFire());
    }

    void Update()
    {
        fireOn = Random.Range(0,2);  

        if(transform.position.x < 9 & transform.position.y > -9){
            onFire = true;
        }else{
            onFire = false;
        }
    }
   
    IEnumerator TimeFire(){

        while(true){

            yield return new WaitForSeconds(0.5f);
            Fire();
        }
    }

    void Fire(){
        if(fireOn == 1 && onFire){

            Instantiate(fireEnemy, transform.position, Quaternion.identity);
        }
    }

}
