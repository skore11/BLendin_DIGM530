using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Balance : MonoBehaviour {
	

	//public float translatespeed= 0.1f;
	public float rotationSpeed = 10f;
	

	//public float rotation = 1000f;

    public bool balancefail;


	void Update()
	{
		
		//rotate1
		//transform.Rotate(Input.GetAxis("Horizontal")*rotation*Time.deltaTime,0,0);

		//transform.Translate (translatespeed,0,0);  //move forward
		//float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		//rotation *= Time.deltaTime;
		//transform.Rotate(rotation,0,0);

		//Get the Screen positions of the object
		//Vector3 positionOnScreen = Camera.main.WorldToViewportPoint (transform.position);

		//Get the Screen position of the mouse
		//Vector3 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);

		//Get the angle between the points
		//float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);

		//Ta Daaa
		//transform.rotation =  Quaternion.Euler (new Vector3(angle,0f,0f));
		//}

		//float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
		//	return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
		//}

		// rotate2
		//if (Input.GetKey (KeyCode.E))  
	
		//	transform.Rotate (Vector3.back * rotationSpeed*Time.deltaTime);

		//if (Input.GetKey (KeyCode.Q))
		//	transform.Rotate (Vector3.forward * rotationSpeed*Time.deltaTime);

        float rotation = Input.GetAxis("LeftJoystickX") * rotationSpeed *Time.deltaTime;
        transform.Rotate(0,0,rotation);

    
		float zrotation = transform.rotation.eulerAngles.z;
		//print (zrotation);

		//print (transform.rotation.eulerAngles.z);

		if (45.0f<transform.rotation.eulerAngles.z && transform.rotation.eulerAngles.z<315.0f)
			
		{  GameObject.Find("warning").GetComponent<Text>().text = "Out of Range "; 
		  balancefail=true;}


		else
		 {GameObject.Find("warning").GetComponent<Text>().text = "Safe"; 
		  balancefail=false;}


			//GetComponent<UnityEngine.UI.Text>().text = "Out of Range "; 

	}


//}






}
