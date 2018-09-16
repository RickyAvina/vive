using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameAgain : MonoBehaviour {

    public Object scene1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

   
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("YEET");
        // Start Game
        
        Application.LoadLevel(scene1.name);
    }
}
