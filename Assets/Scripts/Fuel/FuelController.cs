﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.tag == MainGame.instance.PlayerTag) {
			Destroy (gameObject);
		}
	}
}
