using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tongue1 : MonoBehaviour
{
    public Transform liz;
    private RaycastHit hit;
    private GameObject rb;
    private bool attached = false;
    public float momentum;
   
    public float speed;
    public float step;


    // Use this for initialization
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //int mask = LayerMask.GetMask("fly");
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(liz.position, liz.forward, out hit))
            {
                Debug.Log("hit someshit" + hit);
                rb = hit.collider.gameObject;//assign our private rb the gameobject of raycasthit
                
                Debug.Log(rb.transform.position);
                
               
                attached = true;
               
                hit.rigidbody.isKinematic = true;//once raycast object hit is made kinematic

            }
        }
        if (attached)//when ray is cast and attached to an object
        {


            momentum += Time.deltaTime * speed;//builds up momentum of fly to be eaten 
            step = momentum * Time.deltaTime;
            hit.point = rb.transform.position;//assign the global position of rb.position the hit position hit.point
            rb.transform.position = Vector3.MoveTowards(rb.transform.position, liz.transform.position, step);
            
            if (Vector3.Distance(liz.transform.position, rb.transform.position) <= 1)
            {
                liz.GetComponent<MeshRenderer>().material.color = rb.GetComponent<MeshRenderer>().material.color;
                rb.gameObject.SetActive(false);
               
                attached = false;
               
            }

        }

    }


}




