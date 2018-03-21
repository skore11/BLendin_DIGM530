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
    //private Vector3 rayHitWorldPosition;
    public float speed;
//  	private int rayRange = 100;
    public float step;
	public AudioClip tongue;

    public Color BackgroundColor;
    public string LizardColorString="Original";

	private AudioSource source;
    private Vector2 mousePos;
    private float degree;


	void Start(){
		source = GetComponent<AudioSource>();


	}
   
    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        CheckBackgroundColor();
        degree=GameObject.Find("cursor").GetComponent<RectTransform>().rotation.z;
       // Debug.Log(degree);


        
           mousePos = (Vector2)(Quaternion.Euler(0,0,degree) * Vector2.right);


       
          // Debug.Log(mousePos);


        
        //int mask = LayerMask.GetMask("fly");
        if (Input.GetButtonDown("Right Bumper"))

        { 
            Vector3 mousePosition = new Vector3(0, Camera.main.ScreenToWorldPoint(mousePos).y, Camera.main.ScreenToWorldPoint(mousePos).x);


            //Vector3 mousePosition = new Vector3(0, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, Camera.main.ScreenToWorldPoint(Input.mousePosition).z);

            //Vector3 mousePosition= Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.nearClipPlane, mousePos.y, mousePos.x));

            //Debug.Log(mousePosition);

            //Debug.Log(mousePosition);
			source.PlayOneShot(tongue,1f);
            if (Physics.Raycast(liz.position,mousePosition, out hit))
                {
                
                //Debug.DrawRay(liz.position, mousePosition, Color.green);
                //rayHitWorldPosition = hit.point;
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
            //lineRenderer.SetVertexCount(2);
            Vector3 [] position = new Vector3[2];
            position[0] = liz.position;
            position[1] = rb.transform.position;
            lineRenderer.positionCount = position.Length;
            lineRenderer.SetPositions(position);
            if (Vector3.Distance(liz.transform.position, rb.transform.position) <= 3)
            {
				// we swallow the fly: disable fly, disable line, change color:
				attached = false;
				liz.GetComponent<MeshRenderer>().material.color = rb.gameObject.GetComponent<MeshRenderer>().material.color;// get color of fly
				 LizardColorString=rb.gameObject.tag;
                 lineRenderer.enabled = false;

				rb.gameObject.SetActive(false);
               



               // Debug.Log(LizardColorString);
               
            }
            
        }
    }
		void  CheckBackgroundColor(){
       Vector3 left = liz.transform.TransformDirection(Vector3.left);
       if (Physics.Raycast (liz.position, left, out hit2)) {
                rb2 = hit2.collider.gameObject;
               // Debug.Log ("name of gameobject" + rb2);
                Renderer rend = rb2.GetComponent<MeshRenderer> ();
                if (rend != null) {
                    Texture2D tex = (Texture2D)rend.material.mainTexture;
                    //Debug.Log (rend.material.color);
                    Vector2 pixelUV = hit2.textureCoord;
                    int x = (int) (pixelUV.x * tex.width);
                    int y = (int) (pixelUV.y * tex.height);
                    //Color color = tex.GetPixel (x, y);
                    BackgroundColor=tex.GetPixel (x, y);

                   // Debug.Log ("Pixel color:" + color + " at uv-coord " + x + "," + y + " (pixel " + pixelUV + ")");
		      }
    
       }

    }
}




