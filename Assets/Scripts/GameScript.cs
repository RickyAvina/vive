using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour {

    public GameObject asteroid;
    public int distance;
    public GameObject player;
    public int max_asteroids = 40;
    public float max_range = 30f;

    private List<GameObject> asteroids;

    private float delay = 0.75f;

    // Use this for initialization
    void Start() {
        asteroids = new List<GameObject>();

        for (int i = 0; i < max_asteroids; i++)
        {
            var new_asteroid = (GameObject)Instantiate(asteroid);
            new_asteroid.transform.position = new Vector3(Random.Range(-1f, 1f) * max_range + player.transform.position.x, Random.Range(-1f, 1f) * max_range + player.transform.position.y, Random.Range(-1f, 1f) * max_range + player.transform.position.z);

            for (int j = 0; j < asteroids.Count; j++)
            {
                while ((Vector3.Distance(new_asteroid.transform.position, player.transform.position) < 25) || (Vector3.Distance(asteroids[j].transform.position, new_asteroid.transform.position)) < 3)
                {
                    new_asteroid.transform.position = new Vector3(Random.Range(-1f, 1f) * max_range + player.transform.position.x, Random.Range(-1f, 1f) * max_range + player.transform.position.y, Random.Range(-1f, 1f) * max_range + player.transform.position.z);
                }
                
            }
            asteroids.Add(new_asteroid);
           
        }
	}
	
	// Update is called once per frame
	void Update () {
        delay -= Time.deltaTime;

        if (delay <= 0)
        {
            delay = 0.75f;
            var new_asteroid = (GameObject)Instantiate(asteroid);
            new_asteroid.transform.position = new Vector3(Random.Range(-1f, 1f) * max_range + player.transform.position.x, Random.Range(-1f, 1f) * max_range + player.transform.position.y, Random.Range(-1f, 1f) * max_range + player.transform.position.z);

            for (int j = 0; j < asteroids.Count; j++)
            {
                while ((Vector3.Distance(new_asteroid.transform.position, player.transform.position) < 25) || (Vector3.Distance(asteroids[j].transform.position, new_asteroid.transform.position)) < 3)
                {
                    new_asteroid.transform.position = new Vector3(Random.Range(-1f, 1f) * max_range + player.transform.position.x, Random.Range(-1f, 1f) * max_range + player.transform.position.y, Random.Range(-1f, 1f) * max_range + player.transform.position.z);
                }

            }
            asteroids.Add(new_asteroid);
        }
	}
}
