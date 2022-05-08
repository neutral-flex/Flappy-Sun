using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopScript : MonoBehaviour {

	GameObject playerGameObject;
	playerScript player;
	bool touchedBad = false;
	bool gotPoint = false;


	void Start () {
		playerGameObject = GameObject.FindWithTag ("Player");
		if (playerGameObject != null)
			player = playerGameObject.GetComponent<playerScript> ();
	}

	void Update () {
		if ((player.transform.position.x > transform.position.x + 1f) && (player.transform.position.x < transform.position.x + 2f)) {
			// Game over
			if (!gotPoint) {
				player.gameOver = true;
				Debug.Log ("Game Over!");
			}
		}

		if (player.transform.position.x > transform.position.x + 3f) {
			if (gotPoint) {
				gotPoint = false;
				touchedBad = false;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Player") {
			//touchedBad = true;
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			if (!gotPoint) {
				gotPoint = true;
				if (!touchedBad)
				//playerScript.score += playerScript.combo;
				playerScript.PlayScoreSound = true;
				CoinsCounter.instance.increaseCoins();
				playerScript.score++;
			}		
		}
	}
}

