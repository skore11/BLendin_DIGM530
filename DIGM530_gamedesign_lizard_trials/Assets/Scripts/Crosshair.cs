using UnityEngine;
using System.Collections;
//using System.Collections.Generic;
using UnityEngine.UI;

public class Crosshair : MonoBehaviour {

 private Vector2 StartPosion;
 private Vector2 EndPosition;

  public float offsetx =-50.0f;
  public float offsety =-50.0f;

 public Transform lizard;
 public RectTransform canvasRectT;

   


   // Rect crosshairRect;
   // public Texture crosshairTexture;

 //   public  RectTranform rectTransform; 

  public GameObject objcursor;

  private float t=0;
  public  float timeToReachTarget=0.01f;

	// Use this for initialization
	void Start () {

   
    //cursorPoint.x=Screen.width/2+xoffset;
//    cursorPoint.y=Screen.width/2+yoffset;

    
    StartPosion=objcursor.GetComponent<RectTransform>().anchoredPosition;


   
    // rt=objcursor.GetComponent<RectTransform>();
        //Cursor.visible = false; 

        //float crosshairSize = Screen.width * 0.1f;
        //crosshairTexture = Resources.Load("Assets/Textures/reticle.jpg") as Texture;

        //crosshairRect = new Rect(Screen.width/2 - crosshairSize/2, Screen.height/2 - crosshairSize/2, crosshairSize, crosshairSize);

	}
    void Update()
    {
       // var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        //var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        //var y = Input.GetAxis("Jump") * Time.deltaTime * speed;
        //transform.Translate(x, y, z);

       //float speedx = Screen.width;



       Vector2 screenPoint = RectTransformUtility.WorldToScreenPoint(Camera.main, lizard.position);
     EndPosition = screenPoint - canvasRectT.sizeDelta / 2f ;
     EndPosition.x+=offsetx;
     EndPosition.y+=offsety;
    // EndPosition.y+=Screen.height;

      t += Time.deltaTime/timeToReachTarget;
    
    objcursor.GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp (StartPosion,EndPosition,t);


        //float speedy = Screen.height;
      
       // float x =Input.GetAxis("RightJoystickX") * speedx;
        float y=Input.GetAxis("RightJoystickY");//* speedy;

        //print (x);
    
        //print(Screen.height);
        //print(Screen.width);

        objcursor.GetComponent<RectTransform>().Rotate( new Vector3( 0, 0, y ) );
        
        //Vector3 newPos = new Vector3(x, y,0);

        



       // objcursor.GetComponent<RectTransform>().transform.position = Vector3.MoveTowards( objcursor.GetComponent<RectTransform>().transform.position, newPos, Time.deltaTime * 2.0f);
       
        //objcursor.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);

       
    }
    // Update is called once per frame
   // void OnGUI () {
        //var vectorx = Input.mousePosition.x;
      

        //var vectorx= Input.GetAxis("RightJoystickX")*speed; //* Time.deltaTime * speed;;
     //  var vectory = Input.mousePosition.y;

       // var vectory= Input.GetAxis("RightJoystickY")*speed*10;// * Time.deltaTime * speed;;
        //GUI.DrawTexture(new Rect(vectorx-15, -vectory + Screen.height-15,30,30), crosshairTexture);

      //  GUI.DrawTexture(new Rect(vectorx+Screen.width-100, vectory+Screen.height-250,30,30), crosshairTexture);
	//}
}
