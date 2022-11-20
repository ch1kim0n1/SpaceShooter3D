using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroybycotact : MonoBehaviour {
	public GameObject explosion;
	public GameObject playerexplosion;
	GameController mygame;
	void Start (){
		mygame = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
	}
	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag("boundary")){
			return;
		}
		mygame.AddScore (10);

		Destroy (gameObject);
		Instantiate (explosion, transform.position, Quaternion.identity);

		Destroy (other.gameObject);
		if (other.CompareTag ("Player")) {
			Instantiate (playerexplosion, other.transform.position, Quaternion.identity);
			}
		}
	}