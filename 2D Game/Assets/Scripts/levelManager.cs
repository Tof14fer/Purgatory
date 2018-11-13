using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class levelManager : MonoBehaviour
{

    public GameObject currentCheckPoint;
    public Rigidbody2D PC;
    public GameObject PC2;

    //particles
    public GameObject deathParticle;
    public GameObject respawnParticle;

    //Respawn Delay
    public float respawnDelay;


    //Point Penalty on Death
    public int pointPenaltyOnDeath;

    // Store Gravity Value
    private float gravityStore;


	// Use this for initialization
	private void Start(){
        PC = GameObject.Find("PC").GetComponent<Rigidbody2D>();
        PC2 = GameObject.Find("PC");
    //    PC = FindObjectOfType<Rigidbody2D>();
        }
    public void RespawnPlayer(){
        StartCoroutine("RespawnPC");
    }


    public IEnumerator RespawnPC(){
        //Generate Death Particle
        Instantiate(deathParticle, PC.transform.position, PC.transform.rotation);
        // Hide player
        //PC.enable = false;
        PC2.SetActive(false);
        PC.GetComponent<Renderer>().enabled = false;
        // Reset Gravity
        gravityStore = PC.GetComponent<Rigidbody2D>().gravityScale;
        PC.GetComponent<Rigidbody2D>().gravityScale = 0f;
        PC.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        // Point Penalty
        scoremanager.AddPoints(-pointPenaltyOnDeath);
        // Debug Message
        Debug.Log("PC Respawn");
        // Respawn Delay
        yield return new WaitForSeconds(respawnDelay);
        // Gravity Restore
        PC.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
        // Match Player transform postion
        PC.transform.position = currentCheckPoint.transform.position;
        //Show Player
        //PC.enabled = true;
        PC2.SetActive(true);
        PC.GetComponent<Renderer>().enabled = true;
        //Spawn player
        Instantiate(respawnParticle, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);
    }
}
