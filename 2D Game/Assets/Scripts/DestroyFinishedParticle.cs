using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFinishedParticle : MonoBehaviour {

    private ParticleSystem thisParticelSystem;

	// Use this for initialization
	void Start () {
        thisParticelSystem = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
        if (thisParticelSystem.isPlaying)
            return;

        Destroy(gameObject);
	}

	private void OnBecameInvisible(){
        Destroy(gameObject);
	}

}