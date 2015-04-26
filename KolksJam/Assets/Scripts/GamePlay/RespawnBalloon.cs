using UnityEngine;
using System.Collections;

public class RespawnBalloon : MonoBehaviour {
	
	public GameObject balloon;
	public GameObject arrowRight;
	public GameObject arrowLeft;
	public GameObject arrowUp;
	public GameObject arrowDown;

	private float _tempoRespawn = 0f;
	private float tempoCorrido = 0f;
	
	// Update is called once per frame
	void Update () {
		tempoCorrido += Time.deltaTime;
		_tempoRespawn = Random.Range (4f, 10f);
		if (tempoCorrido >= _tempoRespawn) {
			Instantiate(balloon, transform.position, balloon.transform.rotation);
			tempoCorrido = 0f;
		}
	}
}