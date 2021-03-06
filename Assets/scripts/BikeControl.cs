﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeControl : MonoBehaviour {
	
	public GameObject explosion; // drag your explosion prefab here
	public float bikeSpeed;
	Vector3 position;
	//Jump
	private float jumpTimer = 0.0f;
	private float jumpTime = 5.0f;
	private bool isJumping = false;


	// Use this for initialization
	void Start () {
		position = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		position.x += Input.GetAxis("Horizontal") * bikeSpeed * Time.deltaTime;
		position.x = Mathf.Clamp (position.x, -2.5f, 2.5f);

		//position.y += Input.GetAxis("Vertical") * bikeSpeed * Time.deltaTime;
		//position.y = Mathf.Clamp (position.y, -1.9f, 1.9f);

		transform.position = position;


		//Jump Function
		//rigidbody2D.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
		/*if (Input.GetKeyDown ("space")){
			isJumping = true;
			if (isJumping)
			{
				Debug.Log ("Jumping");
				this.GetComponent<Collider2D> ().enabled = false;
				transform.localScale += new Vector3(0.1F, 0.1f, 0);
				jumpTimer += 1.0f;
				Debug.Log (jumpTimer);

				if (jumpTimer >= jumpTime)
				{
					jumpTimer = 0.0f;
					isJumping = false;
					transform.localScale -= new Vector3(0.1F, 0.1f, 0);

				}
			}

		} */
	



	}

	void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "Vehicle" || col.gameObject.tag == "policeman"){
			if(col.gameObject.tag != "policeman") {
				GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
				Destroy(expl, 1); // delete the explosion after 3 seconds
			
			}
			Invoke ("PauseGame", 1);
			Destroy (gameObject);
			//Invoke ("PauseGame", 1);

		}
	
	}

	void PauseGame () {
		Time.timeScale = 0.0f;
	}
	 

}
