using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public GameObject Hazard;
	int score = 0;
	public Text scoreText;
	public Text TextGameOver;


	// Use this for initialization
	void Start () {
		StartCoroutine ("SpawnWaves");
		scoreText.text = "Score: " + score.ToString ();
		TextGameOver.gameObject.SetActive (false);
	}

	IEnumerator SpawnWaves(){
		while (true) {
		for (int i = 0; i < 5; i++) {
			Instantiate (Hazard, new Vector3 (Random.Range(-6f, 6f), 0, 17), Quaternion.identity);
			yield return new WaitForSeconds (1f);

		}
		yield return new WaitForSeconds (2f);
		
		}

	}
	public void AddScore(int amount){
		score += amount;
		scoreText.text = "Score: " + score.ToString ();
	}

	void Update () {
		
	}


}
