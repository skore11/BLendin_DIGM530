using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tongue : MonoBehaviour {
   /* public Transform liz;
    private RaycastHit hit;
    public GameObject rb;
    private Rigidbody rb2;
    private Transform t1;
    private bool attached = false;
 
    public float momentum;
    public float speed;
    public float step;


	// Use this for initialization
	void Start () {
        rb2 = rb.GetComponent<Rigidbody>();
        t1 = rb.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetButtonDown("Fire1")) {
            if (Physics.Raycast(liz.position, liz.forward, out hit))
            {
                attached = true;
                rb2.isKinematic= true;
                
            }
        }
        if (attached)
        {

            
            momentum += Time.deltaTime * speed;
            step = momentum * Time.deltaTime;
           hit.point = t1.position ;
            t1.position = Vector3.MoveTowards(t1.position, transform.position,   step);
            //Debug.Log(t1.position);
            if (Vector3.Distance(liz.transform.position, t1.position) <= 1)
            {
                Debug.Log("Entered");
                //Destroy(rb.gameObject);
                 rb.gameObject.SetActive(false);
                attached = false;
            }
            
        }
      
    }
  */
    
}
   
  
    

