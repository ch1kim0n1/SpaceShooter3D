using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	Rigidbody rb;
	float tumble = 5f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		//rb.angularVelocity = new Vector3 (500, 500, 500);
		rb.angularVelocity = Random.insideUnitSphere * tumble;
	}
}
