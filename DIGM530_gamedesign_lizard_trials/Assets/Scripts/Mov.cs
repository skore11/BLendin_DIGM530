using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour {

    public float mspeed;


	// Use this for initialization
	void Start () {
        //mspeed = 1f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(mspeed*(Input.GetAxis("Horizontal") * Time.deltaTime), 0f,mspeed* (Input.GetAxis("Vertical") * Time.deltaTime));
        //transform.Rotate(mspeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, mspeed * Input.GetAxis("Vertical") * Time.deltaTime);

    }
}
