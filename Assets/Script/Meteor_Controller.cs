using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor_Controller : MonoBehaviour
{

    GameObject fireEnime;

    //PowerUp
    private float randomTimeSpawn;
    public int meteorSpawn;
    private int ident;
    public GameObject[] meteorAll;

    //public GameObject meteorScene;

    void Start()
    {
        
        InvokeRepeating("MeteorRandom", 5f, 8f);
    }

    void Update()
    {
        
       meteorSpawn = Random.Range(0,4);
       ident = meteorSpawn;

       if(meteorSpawn == ident){
           meteorSpawn = Random.Range(0,4);
       }
    }

    void MeteorRandom(){
        
        randomTimeSpawn = Random.Range(8,20);
        meteorSpawn = Random.Range(0,4);
        Instantiate( meteorAll[meteorSpawn], new Vector3(Random.Range(-8,8),Random.Range(7,12)), Quaternion.identity);
        
    }
}
    

