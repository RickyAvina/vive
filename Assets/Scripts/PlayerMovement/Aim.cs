using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class Aim : MonoBehaviour {
    public SteamVR_TrackedObject leftController;
    public SteamVR_TrackedObject rightController;
    public SteamVR_Controller.Device lDevice;
    public SteamVR_Controller.Device rDevice;

    public float thrust = 2f;
    private Vector3 vel = Vector3.zero;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        lDevice = SteamVR_Controller.Input((int)leftController.index);
        rDevice = SteamVR_Controller.Input((int)rightController.index);

        Vector2 touchValue = lDevice.GetAxis(EVRButtonId.k_EButton_SteamVR_Touchpad);
        float vy = touchValue.y;
        float vx = touchValue.x;


        if (vy > 0)
        {
            vel += Camera.main.transform.forward * thrust * vy * Time.deltaTime;

          //  transform.Translate(Camera.main.transform.forward * thrust * vy * Time.deltaTime);
            //move forward
        }
        if (vy < 0)
        {
            vel += Camera.main.transform.forward * thrust * vy * Time.deltaTime;
           // transform.Translate(Camera.main.transform.forward * thrust * vy * Time.deltaTime);
            //move back
        }
        if (vx > 0)
        {
            vel += Camera.main.transform.right * thrust * vx * Time.deltaTime;
         //   transform.Translate(Camera.main.transform.right * thrust * vx * Time.deltaTime);
            //strife right

        }
        if (vx < 0)
        {
            vel += Camera.main.transform.right * thrust * vx * Time.deltaTime;
            //transform.Translate(Camera.main.transform.right * thrust * vx * Time.deltaTime);
            //strife left 
        }
        if (lDevice.GetPress(EVRButtonId.k_EButton_SteamVR_Touchpad))
        {
            vel += Camera.main.transform.up * thrust * Time.deltaTime;
          //  transform.Translate(Camera.main.transform.up * thrust * Time.deltaTime);
            //move up
           
        }
        if (lDevice.GetPress(SteamVR_Controller.ButtonMask.Trigger))
        {
            vel += -Camera.main.transform.up * thrust * Time.deltaTime;
         //   transform.Translate(-Camera.main.transform.up * thrust * Time.deltaTime);
            //move down
        }

        transform.Translate(vel);
        vel = Vector3.zero;

      
        

    }
}
