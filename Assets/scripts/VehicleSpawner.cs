using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour {

	public GameObject car;
	public GameObject carFromTheSameDirection;

	public float delayTimer = Random.Range(0.0f, 5.9f);
	float timer;
	// Use this for initialization
	void Start () {
		timer = delayTimer;

	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			Vector3 carPosition = new Vector3 (Random.Range(0.1f, 1.9f), transform.position.y, transform.position.z);
			Instantiate (car, carPosition, transform.rotation);

			Vector3 carFromSameDirectionPosition = new Vector3 (Random.Range(-1.9f, -0.3f), transform.position.y, transform.position.z);
			Instantiate (carFromTheSameDirection, carFromSameDirectionPosition, transform.rotation);
		
			timer = delayTimer;
		}
			
		
	}
		
}
