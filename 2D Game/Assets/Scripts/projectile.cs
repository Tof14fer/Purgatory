﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour {
    public float Speed;
    public GameObject PC;
    public float TimeOut;
    public GameObject EnemyDeath;

    public GameObject ProjectileParticle;

    public int PointsForKill;

    // Use this for initialization

	void Start () {
        PC = GameObject.Find("PC");

        EnemyDeath = Resources.Load("Prefabs/Death") as GameObject;

        ProjectileParticle = Resources.Load("Prefabs/Respawn") as GameObject;

        if (PC.transform.localScale.x < 0)
            Speed = -Speed;




        //Destroy Projctile after X time
        Destroy(gameObject, TimeOut);
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
	}

	void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Enemy"){
            Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            scoremanager.AddPoints(PointsForKill);
        }

        //Instantiate(ProjectileParticle, transform.position, transform.rotation);
        Destroy (gameObject);
	}
	private void OnCollisionEnter2D(Collision2D other){
        Instantiate(ProjectileParticle, transform.position, transform.rotation);
        Destroy(gameObject);
	}
}