using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PindiSpawner : MonoBehaviour {

	public GameObject pindiBoy;

	public float delayTimer;
	float timer;
	// Use this for initialization
	void Start () {
		timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			Vector3 carPosition = new Vector3 (Random.Range(-0.0f, 1.9f), transform.position.y, transform.position.z);
			Instantiate (pindiBoy, carPosition, transform.rotation);

			timer = delayTimer;
		}
	}
}
