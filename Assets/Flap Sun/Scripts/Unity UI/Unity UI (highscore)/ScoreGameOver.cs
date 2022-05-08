using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGameOver : MonoBehaviour {

	//zeigt Punkte am ende der runde an

	Text score;

	void Start () {
		score = GetComponent<Text> ();
	}

	void Update () {
		score.text = "Score: " + playerScript.score;
	}
}
