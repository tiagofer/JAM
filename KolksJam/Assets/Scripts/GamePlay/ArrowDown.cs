using UnityEngine;
using System.Collections;

public class ArrowDown : MonoBehaviour {

	public Transform spritePlayer;
	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = spritePlayer.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () {

		animator.SetBool ("clickArrowDown", true);
		Debug.Log ("clicou seta");
	
	
		
	}
}
