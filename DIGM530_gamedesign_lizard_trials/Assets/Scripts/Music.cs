﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {

	public AudioClip music;



	private AudioSource source;



	void Awake () {

		source = GetComponent<AudioSource>();
	}

}
