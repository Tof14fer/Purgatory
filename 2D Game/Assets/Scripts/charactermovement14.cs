using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactermovement14 : MonoBehaviour
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

    //Non-Stick Player
    private float moveVelocity;

    //Player Sprint



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

        // This code makes the character drop
        if (Input.GetKeyDown(KeyCode.S))
        {
            Drop();
        }
        //Non-Stick Player
        moveVelocity = 0f;

        // This codes makes the character move from side to side with A&D keys
        if (Input.GetKey(KeyCode.D))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = MoveSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = -MoveSpeed;

        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

        // Player Flip
        if (GetComponent<Rigidbody2D>().velocity.x > 0)
            transform.localScale = new Vector3(2f, 2f, 1f);
        
        else if (GetComponent<Rigidbody2D>().velocity.x < 0)
            transform.localScale = new Vector3(-2f, 2f, 1f);

    }
    public void Jump(){
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
    }
    public void Drop(){
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -JumpHeight);
    }
} 