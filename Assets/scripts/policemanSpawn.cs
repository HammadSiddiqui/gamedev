using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class policemanSpawn : MonoBehaviour {

	public GameObject policeman;

	public float delayTimer = Random.Range(0.0f, 1.9f);
	float timer;
	// Use this for initialization
	void Start () {
		timer = delayTimer;


	}

	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			Vector3 policemanPosition = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
			Instantiate (policeman, policemanPosition, transform.rotation);
		

			timer = delayTimer;
		}


	}
}
