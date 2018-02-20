using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour {

    public Material[] material;
    MeshRenderer rend;

	// Use this for initialization
	void Start () {
        rend = GetComponent<MeshRenderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];

	}

    // Update is called once per frame
    private void OnCollisionEnter(Collision col)
    {
        Debug.Log("collided");
        /*if (col.gameObject.tag == "Box") 
        {

            rend.material.color = col.gameObject.GetComponent<MeshRenderer>().material.color;
            Debug.Log("collided");
            Debug.Log(material);
//            rend.sharedMaterial = material[1];
           
        }
       /*else
        {
            
        }
        */
    }
}
