﻿using UnityEngine;
using System.Collections;

public class InitCenterEast : Region {
	
	// Use this for initialization
	void Start () {
		IsFull = false;
		LossRate = 13;
		WaterLevel = Random.Range (0,100);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	
}
