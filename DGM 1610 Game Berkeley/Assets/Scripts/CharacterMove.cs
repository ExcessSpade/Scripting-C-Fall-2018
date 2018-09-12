using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// "All We Have To Do Is Decide What To Do With The Time That Is Given To Us"

public class CharacterMove : MonoBehaviour {

	// Player Movement Variables
	public int MoveSpeed;
	public float JumpHeight;

	// Player Grounded Variables
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;

	// Use this for initialization
	void Start () {
		print("Hello World");
	}
	

	void fixedupdate () {
		Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}

	//Wahya Buerre
	// Update is called once per frame
	void Update () {
		
		// This Code Makes The Character Jump
		if(Input.GetKeyDown (KeyCode.Space)&& Grounded){
			Jump();
		}


	}
	public void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}
