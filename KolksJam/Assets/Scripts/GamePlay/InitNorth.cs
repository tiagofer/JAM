using UnityEngine;
using System.Collections;

public class InitNorth : Region {
	// Use this for initialization
	void Start () {
		IsFull = false;
		LossRate = 12;
		WaterLevel = Random.Range (0,100);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
