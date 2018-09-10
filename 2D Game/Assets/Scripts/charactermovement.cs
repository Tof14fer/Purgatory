using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactermovement : MonoBehaviour
{

    // Player Movement Variables
    public int MoveSpeed;
    public float JumpHeight;

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
        if(Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            Jump();
        }
    }

    public void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
    }

}