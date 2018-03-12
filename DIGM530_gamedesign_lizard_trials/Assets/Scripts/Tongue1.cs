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
    private Vector2 mousePos;


	void Start(){
		source = GetComponent<AudioSource>();


	}
   
    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        mousePos=GameObject.Find("cursor").GetComponent<RectTransform>().anchoredPosition; 
       
        
        //int mask = LayerMask.GetMask("fly");
        if (Input.GetButtonDown("Right Bumper"))

        { 

            Vector3 mousePosition = new Vector3(0, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, Camera.main.ScreenToWorldPoint(Input.mousePosition).z);

            //Vector3 mousePosition= Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.nearClipPlane));

            Debug.Log(mousePosition);

            //Debug.Log(mousePosition);
			source.PlayOneShot(tongue,1f);
            if (Physics.Raycast(liz.position,mousePosition, out hit, rayRange))
                {
                
                //Debug.DrawRay(liz.position, mousePosition, Color.green);
                rayHitWorldPosition = hit.point;
               // Debug.Log("hit someshit" + rayHitWorldPosition);
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
				// we swallow the fly: disable fly, disable line, change color:
				attached = false;
				liz.GetComponent<MeshRenderer> ().material.color = rb.gameObject.GetComponent<MeshRenderer>().material.color;// get color of fly
				lineRenderer.enabled = false;
				rb.gameObject.SetActive(false);

				// MOVE THIS CODE TO WHERE YOU CHECK FOR DEATH FROM HAWK:
				// different code for checking color of background:
                Vector3 left = liz.transform.TransformDirection(Vector3.left);
                if (Physics.Raycast(liz.position, left, out hit2))
                {
                    //  liz.GetComponent<MeshRenderer>().material.color = rb.GetComponent<MeshRenderer>().material.color;
                    rb2 = hit2.collider.gameObject;
                   // Debug.Log("name of gameobject" + rb2);
                    Renderer rend = rb2.GetComponent<MeshRenderer>();
                    if (rend != null)
                    {
                        Texture2D tex = (Texture2D)rend.material.mainTexture;
                       // Debug.Log(rend.material.color);
                        //liz.GetComponent<MeshRenderer>().material.color = rend.material.color * ((tex == null) ? Color.white : tex.GetPixel((int)hit2.textureCoord.x, (int)hit2.textureCoord.y)); //reads pixel values of background and transfers to liz color
						Color color = tex.GetPixel((int)hit2.textureCoord.x, (int)hit2.textureCoord.y);
						//Debug.Log("Pixel color:" + color);
						//Debug.Log(liz.GetComponent<MeshRenderer>().material.color);
						//TODO: now check if the colors of us and this one are close enough!
                    }

                }
            }
            
        }

		if (true) { // debugging
			Vector3 left = liz.transform.TransformDirection(Vector3.left);
			if (Physics.Raycast (liz.position, left, out hit2)) {
				rb2 = hit2.collider.gameObject;
				//Debug.Log ("name of gameobject" + rb2);
				Renderer rend = rb2.GetComponent<MeshRenderer> ();
				if (rend != null) {
					Texture2D tex = (Texture2D)rend.material.mainTexture;
					//Debug.Log (rend.material.color);
					Vector2 pixelUV = hit2.textureCoord;
					int x = (int) (pixelUV.x * tex.width);
					int y = (int) (pixelUV.y * tex.height);
					Color color = tex.GetPixel (x, y);
					//Debug.Log ("Pixel color:" + color + " at uv-coord " + x + "," + y + " (pixel " + pixelUV + ")");
				}
			}
		}
    }
   


}




