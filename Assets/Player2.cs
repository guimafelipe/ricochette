﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : Player {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("i")) {
			goUp ();
		} else if (Input.GetKey ("k")) {
			goDown ();
		}
		if (Input.GetKey ("j")) {
			goLeft ();
		} else if(Input.GetKey("l")){
			goRight();
		}
		if (Input.GetKey ("u")) {
			rotateLeft ();
		} else if (Input.GetKey ("o")) {
			rotateRight ();
		}
	}	

}