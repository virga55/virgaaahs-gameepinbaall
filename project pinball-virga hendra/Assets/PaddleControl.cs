using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControl : MonoBehaviour
{
    public KeyCode input;
    public float springPower;
    
    private HingeJoint hinge;
    
    private void Start()
    {
        Debug.log(GetComponent<HingeJoint>());
    }
    private void Update()
    {
        
    }
    private void ReadInput()
    {
        JointSpring jointSpring = hinge.spring;

        if (Input.GetKey(input))
        {
            jointSpring.spring=springPower;
        }
        else
        {
            jointSpring.spring= 0;
        }
        hinge.spring = jointSpring;
    }
}
