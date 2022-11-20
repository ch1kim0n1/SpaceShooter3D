using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	public float speed = 10f;
	Rigidbody rb;
	public float xmin, xmax, zmax, zmin;
	public GameObject bolt;
	public Transform ShotPoint;
	public float rateOfFire = 0.25f;
	float lastFire = 0f;
	AudioSource playerAudio;

	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody> ();

		playerAudio = GetComponent<AudioSource> ();



		
	}

	// Update is called once per frame
	void Update () {
		//Instantiate (bolt, ShotPoint.position, ShotPoint.rotation);
		if (Input.GetButton ("Fire1") && Time.time > lastFire + rateOfFire) {
			Instantiate (bolt, ShotPoint.position, ShotPoint.rotation);
			lastFire = Time.time;
			playerAudio.Play ();
		}
		
		rb.velocity = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis ("Vertical")) * speed;
		//rb.position = new Vector3 (0, 0, 0);
		rb.position = new Vector3 (Mathf.Clamp (rb.position.x, xmin, xmax),
			0, Mathf.Clamp (rb.position.z, zmin, zmax));
		rb.rotation = Quaternion.Euler (0, 0, -rb.velocity.x * -5);
		
	}
}
