﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovebyRigidBody : MonoBehaviour
{
    [SerializeField]
    private float SpeedFactor = 10f;
    [SerializeField]
    private Rigidbody2D Rb;
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>(); 
    }

    
    void Update()
    {
        float horizontalInput =  Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Rb.velocity = new Vector3(horizontalInput, verticalInput, 0f) * SpeedFactor;
    }
}
