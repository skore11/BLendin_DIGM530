using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mov : MonoBehaviour {

    public float mspeed;
	public Text winGame;


	// Use this for initialization
	void Start () {
		winGame.text = "";
		
        //mspeed = 1f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(mspeed*(Input.GetAxis("Horizontal") * Time.deltaTime), 0f,mspeed* (Input.GetAxis("Vertical") * Time.deltaTime));
        //transform.Rotate(mspeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, mspeed * Input.GetAxis("Vertical") * Time.deltaTime);


    }
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "EndGame") {
			winGame.text = "You WIN!!!!";
		}
			

		
	}

}
