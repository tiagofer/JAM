using UnityEngine;
using System.Collections;

public class Baloon : MonoBehaviour {
	
	public GameObject obj;
	private float timeDestroy;
	
	// Use this for initialization
	void Start () {
		timeDestroy = Random.Range (1f, 4f);
		Destroy (obj.GetComponent<BoxCollider2D> (), timeDestroy);
		Destroy (obj, timeDestroy);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown () {
		
		Debug.Log ("clicou");
		//Debug.Log (obj.GetComponent<BoxCollider2D> ().tag);
	}
	
	
}