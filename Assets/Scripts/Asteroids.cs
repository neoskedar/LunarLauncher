﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    public float speed = 7.5f;


    public Rigidbody2D theRB;

     void Start () 
     {
        if(ObstacleController.asteroidDirection <= 5){
        Debug.Log("Going Right");
            theRB.velocity = transform.right * speed;
         } else if(ObstacleController.asteroidDirection > 5) {
             Debug.Log("Going Left");
            theRB.velocity = -transform.right * speed;

         }
 
     }
 
     void Update () 
     {


    }

        private void OnBecameInvisible()
    {

                Destroy(gameObject);
    }
}
