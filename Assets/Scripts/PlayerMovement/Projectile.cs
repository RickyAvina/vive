using UnityEngine;
using System.Collections;
using Valve.VR;
using UnityEngine.UI;

public class Projectile : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public int speed = 4;
    public SteamVR_TrackedObject leftController;
    public SteamVR_TrackedObject rightController;
    public SteamVR_Controller.Device left_device;
    public SteamVR_Controller.Device right_device;
    public float time_despawn = .5f;
    public float size = .3f;

    private int score = 0;

    private double delay = 0.25;

    void Start()
    {
       
    }

    void shoot()
    {
        var bullet = (GameObject)Instantiate(bulletPrefab, new Vector3(bulletSpawn.position.x + 1, bulletSpawn.position.y, bulletSpawn.position.z), bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * speed;
        //var bullet2 = (GameObject)Instantiate(bulletPrefab, new Vector3(bulletSpawn.position.x, bulletSpawn.position.y, bulletSpawn.position.z), bulletSpawn.rotation);
        //bullet2.GetComponent<Rigidbody>().velocity = bullet.transform.forward * speed;
        Destroy(bullet, time_despawn);
       // Destroy(bullet2, 5.0f);
        bullet.transform.localScale = new Vector3(size, size, size);
    }

    private void OnCollisionEnter(Collision collision)
    {
            Destroy(gameObject);
        //c
    }

    // Update is called once per frame
    void Update()
    {
        left_device = SteamVR_Controller.Input((int)leftController.index);
        right_device = SteamVR_Controller.Input((int)rightController.index);

        if (delay <= 0)
        {
            if (right_device.GetPress(SteamVR_Controller.ButtonMask.Trigger))
            {
                shoot();
                delay = 0.25;
            }
        }

        delay -= Time.deltaTime;
    }
}