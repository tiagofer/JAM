using UnityEngine;
using System.Collections;

public class ArrowRight : MonoBehaviour {

	public Transform spritePlayer;
	private Animator animator;
	private bool trigger;

	// Use this for initialization
	void Start () {
		trigger = false;
		animator = spritePlayer.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (trigger) {
			animator.SetBool ("clickArrowRight", trigger);	
			trigger = false;
		}
	}

	void OnMouseDown () {

		trigger = true;
		Debug.Log ("clicou seta");
	
	
		
	}
}
