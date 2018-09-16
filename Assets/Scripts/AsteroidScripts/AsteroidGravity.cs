using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGravity : MonoBehaviour {

    private Rigidbody rb;
    private Rigidbody player;
    private Transform player_transform;
    private bool inRange;
    public float render = 30f;
    public float safe = 30f;

	// Use this for initialization
	void Start () {
        inRange = false;
        rb = GetComponent<Rigidbody>();
        player_transform = FindObjectOfType<PlayerMovement>().transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (inRange)
        {
            transform.position = Vector3.MoveTowards(transform.position, player_transform.position, 2 * Time.deltaTime);
            
        }
        if(Vector3.Distance(rb.transform.position, player_transform.position) < 5){
            inRange = true;
            
        }
        if (Vector3.Distance(rb.transform.position, player_transform.position) > render){
            
            rb.transform.position = new Vector3(Random.Range(-1f, 1f) * render + player_transform.position.x, Random.Range(-1f, 1f) * render + player_transform.position.y,
                                                            Random.Range(-1f, 1f) * render + player_transform.position.z);
            
            while (Vector3.Distance(transform.position, player.transform.position) <(render-10))
            {
                rb.transform.position = new Vector3(Random.Range(-1f, 1f) * render + player_transform.position.x, Random.Range(-1f, 1f) * render + player_transform.position.y,
                                                            Random.Range(-1f, 1f) * render + player_transform.position.z);
            }
        }
	}
}
