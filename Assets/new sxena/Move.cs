using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	Rigidbody rb;
	public float speed = 10f;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.forward * speed;

		
	}
}
