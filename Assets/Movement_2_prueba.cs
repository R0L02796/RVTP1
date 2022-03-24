using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private XRRig rig;
    public CharacterController controller;
    public GameObject camera;
    public float speed = 12f;
    //Start is called Before the first frame update
    void Start()


   rig = GetComponent<XRIG>():
    


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        private void fixedUpdate()
            Quaternion headyaw = Quaternion.Euler(0, rig.camaraGameObject.transform.eulerAngles.y, 0);
        Vector3 move = headyaw * camera.transform.right * x + camera.transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }
}
