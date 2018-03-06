using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noise : MonoBehaviour {

	public AudioClip tongue;



	private AudioSource source;



	void Awake () {

		source = GetComponent<AudioSource>();
	}

}