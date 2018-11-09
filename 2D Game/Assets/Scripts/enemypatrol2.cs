using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemypatrol2 : MonoBehaviour
{
    // Movement Variables
    public float Movespeed;
    public bool Moveright;

    // Wall Check
    public Transform WallCheck;
    public float WallCheckRadius;
    public LayerMask WhatIsWall;
    private bool HittingWall;
    // Edge Check
    private bool NotAtEdge;
    public Transform EdgeCheck;

    //Update is once per frame
    void Update()
    {
        NotAtEdge = Physics2D.OverlapCircle(EdgeCheck.position, WallCheckRadius, WhatIsWall);
        HittingWall = Physics2D.OverlapCircle(WallCheck.position, WallCheckRadius, WhatIsWall);
        if (HittingWall || !NotAtEdge)
        {
            Moveright = !Moveright;
        }

        if (Moveright)
        {
            transform.localScale = new Vector3(-4f, 4f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(Movespeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        else
        {
            transform.localScale = new Vector3(4f, 4f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-Movespeed, GetComponent<Rigidbody2D>().velocity.y);
        }

    }

}