using UnityEngine;

using System.Collections;

using Valve.VR;


[RequireComponent(typeof(SteamVR_TrackedObject))]

public class PlayerMovement: MonoBehaviour
{

    public SteamVR_TrackedObject leftController;
    public SteamVR_TrackedObject rightController;
    public SteamVR_Controller.Device left_device;
    public SteamVR_Controller.Device right_device;
    private Rigidbody rb;
    public int health = 3;

    public float thrust = 1f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Use this for initialization
    void Start()
    {
    }

    void FixedUpdate()
    {
    }

    // Update is called once per frame
    void Update()
    {
        left_device = SteamVR_Controller.Input((int)leftController.index);
        right_device = SteamVR_Controller.Input((int)rightController.index);
       
        if (left_device.GetPress(EVRButtonId.k_EButton_Axis0))
        {
            transform.Translate(Camera.main.transform.forward * thrust * Time.deltaTime);
        }
        else if (right_device.GetPress(EVRButtonId.k_EButton_Axis0))
        {
            transform.Translate(-Camera.main.transform.forward * thrust * Time.deltaTime);
        }

        if(health <= 0)
        {
            //Application.LoadLevel("Defeat");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            health -= 1;
        }
        if (collision.gameObject.tag == "Victory")
        {
            //Application.LoadLevel("Victory");
        }
    }
}
