using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour {

    //public variables
    public float speed = 2.0f;
    public float jumpSpeed = 5.0f;

    //Component references
    private Rigidbody2D rdbd; 

    private bool isJumping=false; 

	// Use this for initialization
	void Start () {
        rdbd = GetComponent<Rigidbody2D>();
	}
	
	
	void FixedUpdate () {
        float horizonatal = Input.GetAxis("Horizontal");

        Vector2 movement = rdbd.velocity;
        movement.x = horizonatal * speed;
        rdbd.velocity = movement;

        if(!isJumping && Input.GetButton("Jump"))
        {
            rdbd.AddForce(new Vector2(0,jumpSpeed));
            isJumping = true;
        }
	}


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collison player");
        if(collision.gameObject.tag == "ground")
        {
            isJumping = false;
        }
    }

    private void OnDestroy()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
