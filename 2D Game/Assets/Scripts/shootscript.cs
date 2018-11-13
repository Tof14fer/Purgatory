using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class shootscript : MonoBehaviour {
    public Transform FirePoint;
    public GameObject Projectile;

    void Start(){
        //Load Projectile from Resources
        Projectile = Resources.Load("Prefabs/Projectile") as GameObject;
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.RightControl))
            Instantiate(Projectile, FirePoint.position, FirePoint.rotation);
	}
}