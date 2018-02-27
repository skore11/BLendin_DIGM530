using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalanceFail : MonoBehaviour {

	public bool balancefail;

	public Text failtext;

	public float timeLeft=7.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    balancefail = GameObject.Find("TailBalance").GetComponent<Balance>().balancefail;

    if (balancefail)
    {
    GetComponent<Mov>().enabled=false;
    GetComponent<Tongue1>().enabled=false;

    failtext.text= "You have 5 sencond to back to Balance!";

    timeLeft -= Time.deltaTime;

	if (5.0f<=timeLeft && timeLeft<6.0f) 

	{failtext.text= "5s";}

    if (4.0f<=timeLeft && timeLeft<5.0f) 

	{failtext.text= "4s";}

	 if (3.0f<=timeLeft && timeLeft<4.0f) 

	{failtext.text= "3s";}


	 if (2.0f<=timeLeft && timeLeft<3.0f) 

	{failtext.text= "2s";}


	 if (1.0f<=timeLeft && timeLeft<2.0f) 

	{failtext.text= "1s";}


	if (0.0f<=timeLeft && timeLeft<1.0f) 

	{failtext.text= "You failed!";}

    }

    else
    {
     GetComponent<Mov>().enabled=true;
     GetComponent<Tongue1>().enabled=true;
     timeLeft=7.0f;
     failtext.text= "";

 }

   

		
	}
}
