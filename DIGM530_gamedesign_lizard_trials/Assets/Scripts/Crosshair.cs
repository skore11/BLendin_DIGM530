using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour {
    float speed = 1.5f;
    Rect crosshairRect;
    public Texture crosshairTexture;
	// Use this for initialization
	void Start () {
        Cursor.visible = false;

        //float crosshairSize = Screen.width * 0.1f;
        //crosshairTexture = Resources.Load("Assets/Textures/reticle.jpg") as Texture;

        //crosshairRect = new Rect(Screen.width/2 - crosshairSize/2, Screen.height/2 - crosshairSize/2, crosshairSize, crosshairSize);

	}
    private void Update()
    {
       // var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        //var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        //var y = Input.GetAxis("Jump") * Time.deltaTime * speed;
        //transform.Translate(x, y, z);
    }
    // Update is called once per frame
    void OnGUI () {
        var vectorx = Input.mousePosition.x;

        //var vectorx= Input.GetAxis("RightJoystickX");
        var vectory = Input.mousePosition.y;

       // var vectory= Input.GetAxis("RightJoystickY");
        GUI.DrawTexture(new Rect(vectorx-15, -vectory + Screen.height-15,30,30), crosshairTexture);
	}
}
