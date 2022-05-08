using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

	//für den Score Text, zum anzeigen des Textes

	Text score;
	public static bool showGUIFromPlayer = false;

	void Start () {
		showGUIFromPlayer = false;
		score = GetComponent<Text> ();
	}

	void Update () {
		if (showGUIFromPlayer) {
			score.gameObject.SetActive(false);
		}
		score.text = "" + playerScript.score;

	}
}
