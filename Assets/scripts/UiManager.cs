using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour {

	// Use this for initialization

	public Text timeText;
	private float time;

	void Start () {
		time = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;

		var minutes = time / 60; //Divide the guiTime by sixty to get the minutes.
		var seconds = time % 60;//Use the euclidean division for the seconds.
		var fraction = (time * 100) % 100;

		//update the label value
		timeText.text = string.Format ("{0:00} : {1:00} : {2:000}", minutes, seconds, fraction);
		
	}
}
