using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour {

	// Use this for initialization
	void Start () {
        levelManager = FindObjectOfType<levelManager>();
		
	}

    // Update is called once per frame
    void Update(){

    }

	void OnTriggerEnter2D(Collider2D collision){
        if(other.name == "PC"){
            levelManager.currentCheckPoint = gameObject;
            Debug.Log("Activated Checkpoint" + transform.position);
        }
	}
}