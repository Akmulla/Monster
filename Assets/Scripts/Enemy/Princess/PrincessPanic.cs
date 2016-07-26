using UnityEngine;
using System.Collections;

public class PrincessPanic : MonoBehaviour 
{
	Rigidbody2D rb;
	Animator anim;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponentInChildren<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (rb.velocity.magnitude >= 0.2f) {
			anim.SetBool ("Panic", true);
		} 
		else 
		{
			anim.SetBool ("Panic", false);
		}
	}
}
