using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;


public class CountDown : MonoBehaviour {

	public float timeLeft=9.0f;
	public bool catchObject=false;
	private int message=3;
	//private  string[] texts = new string[]{"Red!", "Purple!", "Yellow!"};

    private Color purplecolor = new Color32( 0x64, 0x44, 0xE7, 0xFF );
	//public bool showwarning;
	//private int countdown=6;

	// Use this for initialization
	void Start () {

		 message=0;
		  timeLeft = 9.0f;

	}
	
	// Update is called once per frame
	void Update () {

	//GameObject.Find("countdown").GetComponent<Text>().text = timeLeft+ "s";	
   

    //showwarning = GameObject.Find("TailBalance").GetComponent<Balance>().balancefail;



	timeLeft -= Time.deltaTime;

	if (8.0f<=timeLeft && timeLeft<9.0f) 

	{
		    catchObject=false;
		    GameObject.Find("countdown").GetComponent<Text>().text ="5s";}

    if (7.0f<=timeLeft && timeLeft<8.0f) 

	{GameObject.Find("countdown").GetComponent<Text>().text ="4s";}

	 if (6.0f<=timeLeft && timeLeft<7.0f) 

	{GameObject.Find("countdown").GetComponent<Text>().text ="3s";}


	 if (5.0f<=timeLeft && timeLeft<6.0f) 

	{GameObject.Find("countdown").GetComponent<Text>().text ="2s";}



	 if (4.0f<=timeLeft && timeLeft<5.0f) 

	{GameObject.Find("countdown").GetComponent<Text>().text ="1s";}



	if (0.0f<=timeLeft && timeLeft<4.0f) 

	{    
		if(message==0)
		GameObject.Find("countdown").GetComponent<Text>().color=Color.red;
		else if(message==1)
		GameObject.Find("countdown").GetComponent<Text>().color=Color.yellow;
		else if(message==2)
		GameObject.Find("countdown").GetComponent<Text>().color=purplecolor;

        //Debug.Log(GameObject.Find("countdown").GetComponent<Text>().color);

        //string[] texts = new string[]{"Red!", "Purple!", "Yellow!"};

		GameObject.Find("countdown").GetComponent<Text>().text ="Catch!";



        catchObject=true;
}



    if ( timeLeft <= 0 )
     {
         
         
         //StartCoroutine(Example());
        // GameObject.Find("countdown").GetComponent<Text>().text = "Catch!";

         timeLeft = 9.0f;

         GameObject.Find("countdown").GetComponent<Text>().color=Color.white;
          message = Random.Range(0,3);
          Debug.Log(message);
     }


    



		
	}


	//IEnumerator Example()
   // {
        //print(Time.time);
     //   yield return new WaitForSeconds(200);
        //print(Time.time);
   // }


}
