using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour{
    public static int score;

    Text scoretext;

	// Use this for initialization
	void Start () {
        scoretext = GetComponent<Text>();

        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (score < 0)
            score = 0;
        scoretext.text = " " + score;
		
	}

    public static void AddPoints (int pointsToAdd){
        score += pointsToAdd;
    }

    //public static void Reset () {
    //    score = 0;
    //}
}