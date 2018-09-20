using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathbox : MonoBehaviour {


    void OnTriggerEnter2D(GameObject other){

        if (other.name == "PC")
        {
            Debug.Log("PC Enters Death Zone");
            Destroy(other);
        }
     }
  }