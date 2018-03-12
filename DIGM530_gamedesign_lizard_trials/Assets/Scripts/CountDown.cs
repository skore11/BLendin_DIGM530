using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

	public float timeLeft=6.0f;
	public bool catchObject=false;
	private int message=0;
	private  string[] texts = new string[]{"Red!", "Purple!", "Yellow!"};

	//public bool showwarning;
	//private int countdown=6;

	// Use this for initialization
	void Start () {

		

	}
	
	// Update is called once per frame
	void Update () {

	//GameObject.Find("countdown").GetComponent<Text>().text = timeLeft+ "s";	
   

    //showwarning = GameObject.Find("TailBalance").GetComponent<Balance>().balancefail;
   message = Random.Range(1,3);


	timeLeft -= Time.deltaTime;

	if (5.0f<=timeLeft && timeLeft<6.0f) 

	{
		    catchObject=false;
		    GameObject.Find("countdown").GetComponent<Text>().text ="5s";}

    if (4.0f<=timeLeft && timeLeft<5.0f) 

	{GameObject.Find("countdown").GetComponent<Text>().text ="4s";}

	 if (3.0f<=timeLeft && timeLeft<4.0f) 

	{GameObject.Find("countdown").GetComponent<Text>().text ="3s";}


	 if (2.0f<=timeLeft && timeLeft<3.0f) 

	{GameObject.Find("countdown").GetComponent<Text>().text ="2s";}



	 if (1.0f<=timeLeft && timeLeft<2.0f) 

	{GameObject.Find("countdown").GetComponent<Text>().text ="1s";}



	if (0.0f<=timeLeft && timeLeft<1.0f) 

	{

        //string[] texts = new string[]{"Red!", "Purple!", "Yellow!"};

		GameObject.Find("countdown").GetComponent<Text>().text =texts[message];

     catchObject=true;
}



    if ( timeLeft <= 0 )
     {
         
         
         //StartCoroutine(Example());
        // GameObject.Find("countdown").GetComponent<Text>().text = "Catch!";

         timeLeft = 10.0f;
     
     }


    



		
	}


	//IEnumerator Example()
   // {
        //print(Time.time);
     //   yield return new WaitForSeconds(200);
        //print(Time.time);
   // }


}
