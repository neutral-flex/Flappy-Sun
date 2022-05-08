using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreGameOver : MonoBehaviour {

	//Berechnet End-score am ende der Runde

	Text highscore;

	void Start () {
		highscore = GetComponent<Text> ();
	}
	// updated den Score und zeigt Score an
	void Update () {
		highscore.text = "Best: " + playerScript.highscore;
	}
}
