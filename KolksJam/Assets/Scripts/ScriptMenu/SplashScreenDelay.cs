using UnityEngine;
using System.Collections;

public class SplashScreenDelay : MonoBehaviour {
	public float delayTime;


	// Use this for initialization
	IEnumerator Start() {
		yield return new WaitForSeconds (delayTime);
		Application.LoadLevel (1);
	}

}
