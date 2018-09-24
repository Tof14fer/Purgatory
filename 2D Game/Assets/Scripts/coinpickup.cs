using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinpickup : MonoBehaviour{
    public int pointsToAdd;

    void OnTriggerEnter2D(Collider2D other){
        
        if (other.GetComponent<Rigidbody2D>() == null)
            return;

        scoremanager.AddPoints(pointsToAdd);

        Destroy(gameObject);
    }
}