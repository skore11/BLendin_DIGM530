using UnityEngine;
using System.Collections;

public class AddForce : MonoBehaviour {



	//public Component constantForce;
	public float randomforce;



	void Update()
	{
		randomforce=Random.Range (-200, 200);

		transform.Rotate (Vector3.forward * randomforce * Time.deltaTime);


		//StartCoroutine(speedTime());

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
