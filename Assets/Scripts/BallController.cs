﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    [SerializeField] private float shootPower = 10f;
    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
    }

    public void Jump()
    {
        myRigidbody.AddForce(Vector2.up * shootPower, ForceMode2D.Impulse);
    }
}
