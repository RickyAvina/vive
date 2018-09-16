using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lives : MonoBehaviour {

    public Object deathScene;
    public Text text;

    int health = 20;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0)
        {
            Application.LoadLevel(deathScene.name);

        }

        text.text = "Lives: " + health.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        health--;
    }
}
