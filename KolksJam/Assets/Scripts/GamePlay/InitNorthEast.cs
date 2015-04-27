using UnityEngine;
using System.Collections;

public class InitNorthEast : Region {

	public GameObject life;
	private float _timeFinal = 0f;
	private float _timeDecrement = 5f;


	// Use this for initialization
	void Start () {
		IsFull = false;
		LossRate = 10;
		WaterLevel = Random.Range (20,100);

		life.GetComponent<GUIText> ().text = "Nordeste " + WaterLevel.ToString ();
	}
	// Update is called once per frame
	void Update () {
		_timeFinal += Time.deltaTime;
		if (_timeFinal >= _timeDecrement) {
			StartCoroutine ("LossWater");
			_timeFinal = 0f;
		}
	}
	IEnumerator LossWater () {
		
		Debug.Log (WaterLevel);
		if (WaterLevel < 0) {
			Application.LoadLevel (4);
		} else {
			WaterLevel -= LossRate;
			//WaterLevel = (int)WaterLevel;
			life.GetComponent<GUIText> ().text = "Nordeste " + WaterLevel.ToString ();
		}
		yield return new WaitForSeconds (5f);
	}

}