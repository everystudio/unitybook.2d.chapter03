using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    [SerializeField] private HingeJoint2D axisHingeJoint;
    [SerializeField] private Rigidbody2D bodyRigidbody;
    void Update()
    {
        axisHingeJoint.useMotor = Input.GetMouseButton(1);

        if (Input.GetMouseButtonDown(1))
        {
            bodyRigidbody.bodyType = RigidbodyType2D.Dynamic;
        }
    }

    private void FixedUpdate()
    {
        if (bodyRigidbody.IsSleeping() && !Input.GetMouseButton(1))
        {
            bodyRigidbody.bodyType = RigidbodyType2D.Static;
        }

    }
}
