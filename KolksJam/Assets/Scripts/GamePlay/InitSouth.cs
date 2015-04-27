
using UnityEngine;
using System.Collections;

public class InitSouth : Region{
	// Use this for initialization
	public GameObject life;
	private float _timeFinal = 0f;
	private float _timeDecrement = 5f;


	void Start () {
		IsFull = false;
		LossRate = 11;
		WaterLevel = Random.Range (20,100);

		life.GetComponent<GUIText> ().text = "Sul "  + WaterLevel.ToString();	
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
			life.GetComponent<GUIText> ().text = "Sul " + WaterLevel.ToString ();
		}
		yield return new WaitForSeconds (5f);
	}

}