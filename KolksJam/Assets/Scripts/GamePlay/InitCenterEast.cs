using UnityEngine;
using System.Collections;

public class InitCenterEast : Region {

	public GameObject life;
	private float _timeFinal = 0f;
	private float _timeDecrement = 5f;


	// Use this for initialization
	void Start () {
		IsFull = false;
		LossRate = 13;
		WaterLevel = Random.Range (20,100);
		life.GetComponent<GUIText> ().text = "Centro Oeste " + WaterLevel.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		//InvokeRepeating ("LossWater", 5f, 5f);
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
				life.GetComponent<GUIText> ().text = "Centro Oeste " + WaterLevel.ToString ();
			}
			yield return new WaitForSeconds (5f);
	}



	
}