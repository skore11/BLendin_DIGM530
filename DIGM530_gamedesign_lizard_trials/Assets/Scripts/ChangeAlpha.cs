﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAlpha : MonoBehaviour
{

    public KeyCode increaseAlpha;
    public KeyCode decreaseAlpha;
    public float alphaLevel = 0.5f;
    public Material material;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(increaseAlpha))
            alphaLevel += 0.05f;
        if(Input.GetKeyDown (decreaseAlpha))
            alphaLevel -= 0.05f;

        GetComponent<Renderer>().material.color= new Color (1, 1, 1, alphaLevel);
	}
}
