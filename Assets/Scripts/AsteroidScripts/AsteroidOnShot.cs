using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidOnShot : MonoBehaviour {

    public float health = 2f;
    private GameObject asteroid;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        //transform.localScale = new Vector3(health/2, health/2, health/2);

        if (health <= 0)
        {
            Destroy(gameObject);
        }

        
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //Game Over
        }
        if(collision.gameObject.tag == "Bullet")
        {
            health -= 1;
        }
    }
}
