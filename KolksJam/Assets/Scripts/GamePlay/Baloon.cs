using UnityEngine;
using System.Collections;

public class Baloon : MonoBehaviour {

	public GameObject obj;
	private float timeDestroy;

	// Use this for initialization
	void Start () {
		timeDestroy = Random.Range (1f, 4f);
		Destroy (obj, timeDestroy);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
