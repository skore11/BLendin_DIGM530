using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vision : MonoBehaviour {

    public RectTransform canvasRectT;

     public Transform lizard;

	public GameObject visionimg;

	private Vector2 StartPosion;
	private Vector2 EndPosition;
	private Vector2 CurrentPosition;
	public float speed=0.01f;
	private float t=0;
	public  float timeToReachTarget=5.0f;

    public float offsetx =-50.0f;
     public float offsety =-50.0f;
    private Color oColor;

    private Color nColor;

    public float timeToCheck = 60.0f;
    

	// Use this for initialization
	void Start () {

		
		StartPosion.x=-300.0f;
		//EndPosition.x=-127.0f; 

		StartPosion.y=Screen.height;
		//StartPosion.y=200.0f;
        visionimg.GetComponent<RectTransform>().anchoredPosition=StartPosion;
        //Debug.Log(Screen.height);
     
		//EndPosition.y=80.0f;
	}

	
	// Update is called once per frame
	void Update () {
     
     //timeLeft -= Time.deltaTime;
		CatchVersion();

       if(!GameObject.Find("countdown").GetComponent<CountDown>().catchObject)
       { 
       	Image image = visionimg.GetComponent<Image>();
         Color c = image.color;
         c.a = 0.5f;
         image.color = c;}

       //	CatchVersion();}
   
       else if(GameObject.Find("countdown").GetComponent<CountDown>().catchObject)
       {lerpAlpha();
       	// CurrentPosition= visionimg.GetComponent<RectTransform>().anchoredPosition ;
        //visionimg.GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp (EndPosition,StartPosion,1);
        //StartCoroutine(Example());
        // visionimg.GetComponent<RectTransform>().anchoredPosition=StartPosion;
        //ReCatchVersion();
       }
       	//visionimg.GetComponent<RectTransform>().anchoredPosition=StartPosion;}
  
        
	}
    

    void CatchVersion(){
     //CurrentPosition=visionimg.GetComponent<RectTransform>().anchoredPosition ;
     visionimg.GetComponent<RectTransform>().anchoredPosition =StartPosion;
	 Vector2 screenPoint = RectTransformUtility.WorldToScreenPoint(Camera.main, lizard.position);
     EndPosition = screenPoint - canvasRectT.sizeDelta / 2f ;
     EndPosition.x+=offsetx;
     EndPosition.y+=offsety;
    // EndPosition.y+=Screen.height;

	    t += Time.deltaTime/timeToReachTarget;
		
     visionimg.GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp (StartPosion,EndPosition,t);
   //  visionimg.GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp (EndPosition,StartPosion,t);

    }




	 void lerpAlpha(){	
	  oColor=visionimg.GetComponent<Image>().color;
      nColor=visionimg.GetComponent<Image>().color;
      oColor.a=100.0f;
      visionimg.GetComponent<Image>().color=oColor;
       nColor.a=255.0f;
	 	float lerp= Mathf.PingPong (Time.deltaTime,timeToCheck )/timeToCheck;
	 	//float alphalerp =Mathf.Lerp(0.5,1.0,lerp);
	 	//visionimg.GetComponent<Image>().color =Color.Lerp (oColor, nColor, Mathf.PingPong(Time.time, 100));
         visionimg.GetComponent<Image>().color =Color.Lerp (oColor, nColor, lerp*100);
	 }

   // IEnumerator Example()
  //  {
        
     //  yield return new WaitForSeconds(5);
    //  visionimg.GetComponent<RectTransform>().anchoredPosition =StartPosion;
   // }
	  
}
