using UnityEngine;
using System.Collections;

public class ArrowUp : MonoBehaviour {

	public Transform spritePlayer;
	private Animator animator;
	private bool trigger = false;

	// Use this for initialization
	void Start () {
		animator = spritePlayer.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (trigger) {
			animator.SetBool ("clickArrowUp", trigger);
		}
		trigger = false;
		animator.SetBool ("clickArrowUp", trigger);
	}

	void OnMouseDown () {
		trigger = true;
		Debug.Log ("clicou seta");	
	}

	void OnMouseUp () {
		trigger = false;
	}
}
