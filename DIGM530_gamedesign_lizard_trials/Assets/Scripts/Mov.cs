using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mov : MonoBehaviour {


	public Text winGame;

	public Transform startMarker;
	public Transform endMarker;
	public float speed = 1.0F;
	private float startTime;
	private float journeyLength;
	void Start() {
		startTime = Time.time;
		journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
		winGame.text = "";
	}
	void Update() {
		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;
		transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
	}
		
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "EndGame") {
			winGame.text = "You WIN!!!!";	
		}
	}
}


