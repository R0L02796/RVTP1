using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedFall : MonoBehaviour
{
    public GameObject cube;
    bool fall = false;
    float fallTime = 30.0F;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody m_Rigidbody = GetComponent<Rigidbody>();
        float time =  Time.time;

        if(time > fallTime){
            if(!fall){
                fall = true;
                m_Rigidbody.AddForce(transform.forward * 1000.0F);
            }
        }
        
    }
}
