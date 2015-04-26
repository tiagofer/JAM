using UnityEngine;
using System.Collections;

public class RespawnBalloon : MonoBehaviour {
	
	public GameObject balloon;
	public Transform north;
	public Transform south;
	public Transform southEast;
	public Transform centerEast;
	public Transform northEast;
	public BoxCollider2D box;



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
		
				Instantiate(balloon, north.position, balloon.transform.rotation);


				if (balloon.GetComponent<BoxCollider2D> () == null) {
					box = balloon.AddComponent<BoxCollider2D> ();

				}
				tempoCorrido = 0f;
			} else if (region == 2) {

				Instantiate(balloon, south.position, balloon.transform.rotation);

				//box = balloon.AddComponent<BoxCollider2D> ();
				if (balloon.GetComponent<BoxCollider2D> () == null) {
					box = balloon.AddComponent<BoxCollider2D> ();

				}
				tempoCorrido = 0f;
			} else if (region == 3) {

				Instantiate(balloon, southEast.position, balloon.transform.rotation);

				//box = balloon.AddComponent<BoxCollider2D> ();
				if (balloon.GetComponent<BoxCollider2D> () == null) {
					box = balloon.AddComponent<BoxCollider2D> ();

				}
				tempoCorrido = 0f;
			} else if (region == 4) {

				Instantiate(balloon, centerEast.position, balloon.transform.rotation);
				//box = balloon.AddComponent<BoxCollider2D> ();
				if (balloon.GetComponent<BoxCollider2D> () == null) {
					box = balloon.AddComponent<BoxCollider2D> ();

				}
				tempoCorrido = 0f;
			} else if (region == 5) {

				Instantiate(balloon, northEast.position, balloon.transform.rotation);

				//box = balloon.AddComponent<BoxCollider2D> ();
				if (balloon.GetComponent<BoxCollider2D> () == null) {
					box = balloon.AddComponent<BoxCollider2D> ();

				}
				tempoCorrido = 0f;
			}
		}
	}

}