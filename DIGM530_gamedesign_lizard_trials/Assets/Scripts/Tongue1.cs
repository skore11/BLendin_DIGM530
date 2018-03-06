using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tongue1 : MonoBehaviour
{
    public Transform liz;
    private RaycastHit hit;
    private RaycastHit hit2;
    private GameObject rb;
    private GameObject rb2;
    private bool attached = false;
    public float momentum;
    private float mouseposY;
    private Vector3 rayHitWorldPosition;
    public float speed;
  	private int rayRange = 100;
    public float step;
	public AudioClip tongue;

	private AudioSource source;


	void Start(){
		source = GetComponent<AudioSource>();
	}
   
    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        
        
        //int mask = LayerMask.GetMask("fly");
        if (Input.GetButtonDown("A"))
        {
            Vector3 mousePosition = new Vector3(0, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, Camera.main.ScreenToWorldPoint(Input.mousePosition).z);
            //Debug.Log(mousePosition);
			source.PlayOneShot(tongue,1f);
            if (Physics.Raycast(liz.position,mousePosition, out hit, rayRange))
                {
                
                //Debug.DrawRay(liz.position, mousePosition, Color.green);
                rayHitWorldPosition = hit.point;
                Debug.Log("hit someshit" + rayHitWorldPosition);
                //mouseposY = hit.point.y;
                //Debug.Log("hit someshit" + hit);
                rb = hit.collider.gameObject;//assign our private rb the gameobject of raycasthit
                
               // Debug.Log(rb.transform.position);
                

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
            
            LineRenderer lineRenderer = liz.GetComponent<LineRenderer>();
            lineRenderer.enabled = true;
            lineRenderer.SetVertexCount(2);
            lineRenderer.SetPosition(0, liz.position);
            lineRenderer.SetPosition(1, rb.transform.position);
            if (Vector3.Distance(liz.transform.position, rb.transform.position) <= 1)
            {
                Vector3 left = liz.transform.TransformDirection(Vector3.left);
                if (Physics.Raycast(liz.position, left, out hit2))
                {
                    //  liz.GetComponent<MeshRenderer>().material.color = rb.GetComponent<MeshRenderer>().material.color;
                    rb2 = hit2.collider.gameObject;
                    Debug.Log("name of gameobject" + rb2);
                    Renderer rend = rb2.GetComponent<MeshRenderer>();
                    if (rend != null)
                    {
                        Texture2D tex = (Texture2D)rend.material.mainTexture;
                        Debug.Log(rend.material.color);
                        //liz.GetComponent<MeshRenderer>().material.color = rend.material.color * ((tex == null) ? Color.white : tex.GetPixel((int)hit2.textureCoord.x, (int)hit2.textureCoord.y)); //reads pixel values of background and transfers to liz color
                        liz.GetComponent<MeshRenderer>().material.color= liz.GetComponent<MeshRenderer>().material.color * (tex.GetPixel((int)hit2.textureCoord.x, (int)hit2.textureCoord.y)); //reads pixel values of background and transfers to liz color
                        //liz.GetComponent<MeshRenderer>().material.mainTexture = tex;
                        //Debug.Log(tex.GetPixel((int)hit2.textureCoord.x, (int)hit2.textureCoord.y));
                        Debug.Log(liz.GetComponent<MeshRenderer>().material.color);
                    }
                    rb.gameObject.SetActive(false);

                    attached = false;
                }
            }
            
        }

    }
   


}




