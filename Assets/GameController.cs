using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public GameObject hazard;

	// Use this for initialization
	void Start () {
		Instantiate (hazard, new Vector3 (0, 10, 0), Quaternion.identity);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
