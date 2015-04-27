using UnityEngine;
using System.Collections;

public class BaloonDestroy : MonoBehaviour {
	
	//public GameObject obj;
	private float timeDestroy;

	// Use this for initialization
	void Start () {
		timeDestroy = Random.Range (1f, 4f);
	//	Destroy (obj.GetComponent<BoxCollider2D> (), timeDestroy);
		Destroy (this.gameObject, timeDestroy);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown () {

		Debug.Log ("clicou");
		Application.LoadLevel ("TelaDanca");
	}
}