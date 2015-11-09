﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class Life : MonoBehaviour {

	public int hitpoints = 10;
	public GameObject hitpointsScreen;
	private Text txt;

	// Use this for initialization
	void Start () {
		txt = hitpointsScreen.GetComponent<Text>();
		txt.text = hitpoints.ToString();
	}

	void Update (){
		txt = hitpointsScreen.GetComponent<Text>();
		txt.text = hitpoints.ToString();
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Enemy") {
			hitpoints--;
		}
	}
}
