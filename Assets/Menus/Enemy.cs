using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Enemy.cs
public class Enemy : MonoBehaviour
{

    //public GameObject explosionPrefab;
    public int fullLife = 2;


    public void enemyhit(int life)
    {


        //subtract life  when Damage function is called
        fullLife -= life;

        //Check if full life has fallen below zero
        if (fullLife <= 0)
        {
            //Destroy the enemy if the full life is less than or equal to zero
            Destroy(gameObject);

        }
    }

    private void OnTriggerEnter(Collider other)
    {

    }

    private void Update()
    {

    }
    // if the hit object is the enemy
    //Raycastexample.cs from where we are calling the enemyhit function

}