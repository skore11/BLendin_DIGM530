using UnityEngine;
using System.Collections;

public class AddForce : MonoBehaviour {



	//public Component constantForce;
	public float randomforce;

	private RectTransform tail;
	private float rotateZ;
	private float gotoforce;

	private float smooth=2.0f;

	void Start(){
		//randomforce=200.0f;

		tail=transform.GetComponent<RectTransform>();


		
	}



	void Update()
	{
		
		
		randomforce=Random.Range(-200.0f, 200.0f);

		//randomforce=20f;

		float zrotationange=tail.rotation.eulerAngles.z;
		
 

      
       if( (zrotationange>0.0f &&  zrotationange<15.0f) || ( zrotationange>345.0f &&  zrotationange<360.0f) || zrotationange==0.0f || zrotationange==360.0f  )
    
         { transform.Rotate (new Vector3(0,0,1) * randomforce * Time.deltaTime);}

          //Debug.Log(zrotationange);}


       else if((zrotationange<345.0f && zrotationange>300.0f) || zrotationange==345.0f )

        {transform.Rotate (new Vector3(0,0,1) * (-50.0f) * Time.deltaTime);
        	//Debug.Log(zrotationange);
      	
        }



        else if((zrotationange<300.0f && zrotationange>270.0f) || zrotationange==300.0f )

        {transform.Rotate (new Vector3(0,0,1) * (-80.0f) * Time.deltaTime);
        
      	
        }


        else if((zrotationange<270.0f && zrotationange>180.0f)  || zrotationange==270.0f )

        {transform.Rotate (new Vector3(0,0,1) * (0.0f) * Time.deltaTime);	
      	
        }




       else if((zrotationange>15.0f && zrotationange<60.0f) || zrotationange==15.0f )

        {transform.Rotate (new Vector3(0,0,1) * (50.0f) * Time.deltaTime);
        	
      	
        }


        else if((zrotationange>60.0f && zrotationange<90.0f) || zrotationange==60.0f )

        {transform.Rotate (new Vector3(0,0,1) * (80.0f) * Time.deltaTime);
        	      	
        }


        else if((zrotationange>90.0f && zrotationange<180.0f) || zrotationange==90.0f )

        {transform.Rotate (new Vector3(0,0,1) * (0.0f) * Time.deltaTime);
        	      	
        }



         else if(zrotationange==180.0f )

        {transform.Rotate (new Vector3(0,0,1) * (0.0f) * Time.deltaTime);
                  
        }


  


  /*     if(tail.rotation.eulerAngles.z>10.0f)
          
        {
        	transform.Rotate (new Vector3(0,0,1) * 10.0f * Time.deltaTime);

            if(tail.rotation.eulerAngles.z>20.0f) 

            { Debug.Log("left");
               transform.Rotate (new Vector3(0,0,1) * 20.0f * Time.deltaTime);
           }

        }   


       else if(tail.rotation.eulerAngles.z<-10.0f) 

      { 
      	transform.Rotate (new Vector3(0,0,1) * 10.0f * Time.deltaTime);


            if(tail.rotation.eulerAngles.z<-20.0f) 
        
        {

      	Debug.Log("right");
       transform.Rotate (new Vector3(0,0,1) * (-20.0f) * Time.deltaTime);
        }

}


      /*

//
     // Quaternion target = Quaternion.Euler(0, 0, 30);

    //    transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);

    

 
      else  if(tail.rotation.eulerAngles.z>10.0f)

        { transform.Rotate (Vector3.forward * (50.0f) * Time.deltaTime);
        	//Debug.Log(tail.rotation.eulerAngles.z+"1");
        	//transform.rotation = Quaternion.Euler(0,0,40);
        	if(tail.rotation.eulerAngles.z>20.0f)
        	{transform.Rotate (Vector3.forward * (100.0f) * Time.deltaTime);
        			//Debug.Log(tail.rotation.eulerAngles.z+"2");

             if(tail.rotation.eulerAngles.z>30.0f)
             {
             	transform.Rotate (Vector3.forward * (150.0f) * Time.deltaTime);
             		//Debug.Log(tail.rotation.eulerAngles.z+"3");
             	if(tail.rotation.eulerAngles.z>45.0f)

             	{
             		transform.Rotate (Vector3.forward * (200.0f) * Time.deltaTime);
                    if(tail.rotation.eulerAngles.z>80.0f)

                    {//Debug.Log("here");

                    	 transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 90), Time.deltaTime * 5.0f);
                    	 	//Debug.Log(tail.rotation.eulerAngles.z+"4");
                    }

             	}
             }

        	}        

        }




      else  if(tail.rotation.eulerAngles.z< -10.0f)

        { transform.Rotate (Vector3.forward * (-50.0f) * Time.deltaTime);
        	Debug.Log(tail.rotation.eulerAngles.z+"-1");
        	//transform.rotation = Quaternion.Euler(0,0,40);

        	if(tail.rotation.eulerAngles.z<-20.0f)
        	{transform.Rotate (Vector3.forward * (-100.0f) * Time.deltaTime);
        			Debug.Log(tail.rotation.eulerAngles.z+"-2");


             if(tail.rotation.eulerAngles.z<-30.0f)
             {
             	transform.Rotate (Vector3.forward * (-150.0f) * Time.deltaTime);
             		Debug.Log(tail.rotation.eulerAngles.z+"-3");
             	if(tail.rotation.eulerAngles.z<-45.0f)

             	{
             		transform.Rotate (Vector3.forward * (-200.0f) * Time.deltaTime);
                    if(tail.rotation.eulerAngles.z<-80.0f)

                    {Debug.Log("here");

                    	 transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, -90), Time.deltaTime * 5.0f);
                    	 	Debug.Log(tail.rotation.eulerAngles.z+"-4");

                    }

             	}
             }


        	}

        

        }*/



	}






	//IEnumerator speedTime ()
	//{
	//	yield return new WaitForSeconds(1);
	//	revertSpeed();
	//}

	//void revertSpeed ()
	//{
	//	translatespeed=0.1f;
	//}


}
