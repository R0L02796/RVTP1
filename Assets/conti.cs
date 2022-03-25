using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class continus_movment : MonoBehaviour
{
    public float speed = 1;
    public XRNode inputSource;
    private Vector2 inputAxis;
    public CharacterController character;

   

    public CharacterController GetCharacter()
    {
        return character;
    }




    // Start is called before the first frame update
    // void Start()
    // {
    //  SetCharacter(GetComponent<CharacterController>());
    //  }

    // Update is called once per frame
    void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);
    }
    private void FixedUpdate()
    {

        Vector3 direction = new Vector3(inputAxis.x, 0, inputAxis.y);

        GetCharacter().Move(direction * Time.fixedDeltaTime * speed);

    }


}
