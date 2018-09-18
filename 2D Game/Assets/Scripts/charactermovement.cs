﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactermovement : MonoBehaviour
{

    // Player Movement Variables
    public int MoveSpeed;
    public float JumpHeight;
    private bool doublejump;

    // Player grounded Variables
    public Transform GroundCheck;
    public float GroundCheckRadius;
    public LayerMask WhatIsGround;
    private bool grounded;

    // Use this for initialization
    void Start()
    {

    }



    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
    }

    // Update is called once per frame
    void Update()
    {

        // This code makes the character jump
        if (Input.GetKeyDown(KeyCode.W) && grounded)
        {
            Jump();
        }

        //Double Jump Code
        if (grounded)
            doublejump = false;

        if (Input.GetKeyDown(KeyCode.W) && !doublejump && !grounded)
        {
            Jump();
            doublejump = true;
        }

        // This codes makes the character move from side to side with A&D keys
        if (Input.GetKey(KeyCode.D))
        {

            GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);

        }


    }
    public void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
    }
}