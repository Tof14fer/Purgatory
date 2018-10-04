using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killplayer : MonoBehaviour {

    public levelManager levelManager;

	// Use this for initialization
	void Start () {
        levelManager = FindObjectOfType<levelManager>();
	}



    private void OnTriggerEnter2D(Collider2D other){
        if(other.name == "PC"){
            levelManager.RespawnPlayer();
        }
    }
}