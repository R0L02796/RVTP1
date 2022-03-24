using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public CharacterController controller;
    public GameObject camera;
    public float speed = 12f;
 
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = camera.transform.right * x + camera.transform.forward * z;

        controller.Move( move * speed * Time.deltaTime);
    }
}
