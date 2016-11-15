﻿using UnityEngine;
using System.Collections;

public class playerJump : MonoBehaviour {

	public float jumpStrength;
	private Vector3 yVelocity;

	public float gravity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space)) {

			//set the velocity to equal (0, jumStrength, 0) when we press spacebar
			yVelocity = new Vector3(0, jumpStrength, 0);
		}

		//give the player upwards velocity
		transform.position += yVelocity * Time.deltaTime;

		if (transform.position.y > 1) {
			
			yVelocity.y -= gravity;

		} else {
			
			yVelocity.y = 0;

			transform.position = new Vector3(transform.position.x, 1.0f, transform.position.z);
		}


	
	}
}
