using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PindiBoy : MonoBehaviour {

	public Transform target;//set target from inspector instead of looking in Update
	public float speed = 3f;
	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {

	
		//move towards the player
		if (Vector3.Distance(transform.position,target.position) > 1f) {
			//move if distance from target is greater than 1
			transform.Translate(new Vector3(0,speed* Time.deltaTime,0) );
		}
	}

	void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "Vehicle" || col.gameObject.tag == "policeman") {
			Destroy (gameObject);
		}
	}

}
