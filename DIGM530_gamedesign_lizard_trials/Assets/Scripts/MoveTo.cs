using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class MoveTo : MonoBehaviour {

	public  Transform target;
	public bool stayBack = false;
	public float stayBackDist = 10f;
	private NavMeshAgent myAgent;
	public Text winGame;

	// Use this for initialization
	void Start () {
		myAgent = GetComponent<NavMeshAgent> ();
		winGame.text = "";

	}
	
	// Update is called once per frame
	void Update () {
		if (stayBack) {
			// Get a vector from my position to target
			Vector3 offset = target.position - transform.position;
			// How far from target?
			if (offset.magnitude <= stayBackDist)
			{
				print("The target transform is close to me!");
				// Stay here
				myAgent.destination = transform.position;
			}
			else {
				// Move forward
				myAgent.destination = target.position;
			}
		}
		else
		{
			myAgent.destination = target.position;
		}
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "EndGame") {
			winGame.text = "You WIN!!!!";	
		}
	}
}
