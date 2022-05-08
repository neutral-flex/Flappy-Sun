using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreText : MonoBehaviour {

	//für den Highscore Text, zum anzeigen des Textes

	public static int scoreValue = 0;
	public static Text highscore;
	public static bool showGUIFromPlayer = false;

	void Start () {
		showGUIFromPlayer = false;
		highscore = GetComponent<Text> ();
	}

	void Update () {
		if (showGUIFromPlayer) {
			highscore.gameObject.SetActive(false);
		}
		highscore.text = "Best Score: " + playerScript.highscore;
		}
	}

