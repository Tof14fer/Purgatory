using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {
    public charactermovement14 PC;

    public bool isFollowing;


    //Camera position offset
    public float xOffset;
    public float yOffset;

	// Use this for initialization
	void Start () {
        PC = FindObjectOfType<charactermovement14>();

        isFollowing = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (isFollowing){
            transform.position = new Vector3(PC.transform.position.x, PC.transform.position.y + yOffset, transform.position.z);
        }
	}
}