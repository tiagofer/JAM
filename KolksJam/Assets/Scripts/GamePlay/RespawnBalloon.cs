using UnityEngine;
using System.Collections;

public class RespawnBalloon : MonoBehaviour {
	
	public GameObject balloon;
	public Region north;
	public Transform south;
	public Transform southEast;
	public Transform centerEast;
	public Transform northEast;
	private BoxCollider2D box;
	
	
	private float _tempoRespawn = 0f;
	private float tempoCorrido = 0f;
	private int region;
	
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		tempoCorrido += Time.deltaTime;
		_tempoRespawn = Random.Range (4f, 10f);
		region = Random.Range (1, 6);
		if (tempoCorrido >= _tempoRespawn) {
			if(region == 1) {
				
				Instantiate(balloon, north.transform.position, north.transform.rotation);
				balloon.gameObject.tag = "Norte";
				if (balloon.GetComponent<BoxCollider2D> () == null) {
					balloon.AddComponent<BoxCollider2D> ();
					
				}
				//				if (Input.GetMouseButton(0)){
				//					Ray ray;
				//					RaycastHit2D hit;
				//					ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				//					if (Physics.Raycast(ray, hit)){
				//						Debug.Log("Clicou no cubo");
				//					}
				//
				//				}
				tempoCorrido = 0f;
			} else if (region == 2) {
				
				Instantiate(balloon, south.transform.position, south.transform.rotation);
				//box = balloon.AddComponent<BoxCollider2D> ();
				balloon.gameObject.tag = "Sul";
				Debug.Log (south.transform.position);
				Debug.Log(balloon.tag);
				if (balloon.GetComponent<BoxCollider2D> () == null) {
					box = balloon.AddComponent<BoxCollider2D> ();
				}
				//				if (Input.GetMouseButton(0)){
				//					Ray ray;
				//					RaycastHit2D hit;
				//					ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				//					if (Physics.Raycast(ray, hit)){
				//						Debug.Log("Clicou no cubo");
				//					}
				//					
				//				}
				tempoCorrido = 0f;
			} else if (region == 3) {
				
				Instantiate(balloon, southEast.position, balloon.transform.rotation);
				//box = balloon.AddComponent<BoxCollider2D> ();
				balloon.gameObject.tag = "Sudeste";
				Debug.Log (south.transform.position);
				Debug.Log(balloon.tag);
				if (balloon.GetComponent<BoxCollider2D> () == null) {
					box = balloon.AddComponent<BoxCollider2D> ();
				}
				//				if (Input.GetMouseButton(0)){
				//					Ray ray;
				//					RaycastHit2D hit;
				//					ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				//					if (Physics.Raycast(ray, hit)){
				//						Debug.Log("Clicou no cubo");
				//					}
				//					
				//				}
				tempoCorrido = 0f;
			} else if (region == 4) {
				
				Instantiate(balloon, centerEast.position, balloon.transform.rotation);
				//box = balloon.AddComponent<BoxCollider2D> ();
				balloon.gameObject.tag = "CentroOeste";
				Debug.Log (south.transform.position);
				Debug.Log(balloon.tag);
				if (balloon.GetComponent<BoxCollider2D> () == null) {
					box = balloon.AddComponent<BoxCollider2D> ();
				}
				//				if (Input.GetMouseButton(0)){
				//					Ray ray;
				//					RaycastHit2D hit;
				//					ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				//					if (Physics.Raycast(ray, hit)){
				//						Debug.Log("Clicou no cubo");
				//					}
				//					
				//				}
				tempoCorrido = 0f;
			} else if (region == 5) {
				
				Instantiate(balloon, northEast.position, balloon.transform.rotation);
				//box = balloon.AddComponent<BoxCollider2D> ();
				balloon.gameObject.tag = "Nordeste";
				Debug.Log (south.transform.position);
				Debug.Log(balloon.tag);
				if (balloon.GetComponent<BoxCollider2D> () == null) {
					box = balloon.AddComponent<BoxCollider2D> ();
				}
				//				if (Input.GetMouseButton(0)){
				//					Ray ray;
				//					RaycastHit2D hit;
				//					ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				//					if (Physics.Raycast(ray, hit)){
				//						Debug.Log("Clicou no cubo");
				//					}
				//					
				//				}
				tempoCorrido = 0f;
			}
		}
	}
	

}
