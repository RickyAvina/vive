using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {

    public Object winScene;
    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(this.transform.position, player.transform.position) <= 20)
        {
            Application.LoadLevel(winScene.name);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ERERER");
      //  if (collision.gameObject.name == "Player")
      //  {
            Application.LoadLevel(winScene.name);
        //}
    }
}
