using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Movement : MonoBehaviour
{
    private XRRig rig;
    public CharacterController controller;
    public GameObject camera;
    public float speed = 12f;
 
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Quaternion headyaw = Quaternion.Euler(0, rig.cameraGameObject.transform.eulerAngles.y, 0);
        

        

        Vector3 move = camera.transform.right * x + camera.transform.forward * z;

        controller.Move( move * speed * Time.deltaTime);
    }
}
