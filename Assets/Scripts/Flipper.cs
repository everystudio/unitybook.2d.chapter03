using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    [SerializeField] private HingeJoint2D myHingeJoint;
    void Update()
    {
        myHingeJoint.useMotor = Input.GetMouseButton(1);
    }
}
