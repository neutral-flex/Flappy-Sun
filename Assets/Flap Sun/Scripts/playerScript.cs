using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class playerScript : MonoBehaviour {

	[Header("Player Settings")]
	public Rigidbody2D PlayerRigidbody; //Rigidbody vom Spieler
	public AudioClip BlockersHitSound; 	//Ton der abgespielt wird, wenn der Spieler den Boden/Blocker trifft
	public float jumpForce; 			//Force vom Spieler Jump
	public float forwardSpeed; 			//Geschwindigkeit vom Movement
	public static int combo = 1; 		//Wird gebraucht um Score zu kalkulieren
	public static int score = 0;        //Wird gebraucht um Score zu kalkulieren
		
	[Header("Score Settings")]
	bool playerJumped = false;			//Ist der Spieler gesprungen?
	public AudioClip ScoreSound;		//Sound wird abgespielt, wenn Spieler einen neuen Punkt bekommt

	[Header("Game Over UI Settings")]
	public GameObject completeGameOverUI;			//Game Over UI wird angezeigt sobald Spieler stirbt
	public AudioClip GameOverSound;					//Game over Sound


	public static int highscore;		//Highscore Value
	public static bool PlayScoreSound = false;
	bool playsound2 = true;
	public bool gameOver = false;
	public static bool Die = false;


	// Sensoren

	public Vector3 accelerationDir;
	// Handheld.Vibrate(); -> siehe OnCollisionEnter2D()


	// Mikro

	


	void Start () {
		score = 0;
	}

	void Update () {

		accelerationDir = Input.acceleration;

		if (score > highscore) {
			highscore = score;
			PlayerPrefs.SetInt ("highscore", highscore);
		}
	

	//	UIScore.text = score.ToString();
	//	UIHighScore.text = "Best: " + playerScript.highscore;


	// Spieler Steuerung/Eingaben



		if (!gameOver) {
			if (Input.GetMouseButtonDown (0) || Input.anyKeyDown || accelerationDir.sqrMagnitude >= 2f) // Maus, Tastatur, Handy Schütteln
				playerJumped = true;
		}

		if (!gameOver) {
			
		if (PlayScoreSound) {
			
				GetComponent<AudioSource>().PlayOneShot(ScoreSound, 7.7F); //spielt Score sound ab
			
			PlayScoreSound = false;
		}
	}
			
}



	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Blockers") {
			GetComponent<AudioSource>().PlayOneShot(BlockersHitSound, 7.7F); //spielt Score sound ab
			gameOver = true;
			Handheld.Vibrate();
			StartCoroutine(Example());

		}
	}



	IEnumerator Example()
	{
		yield return new WaitForSeconds(2);
		if (playsound2) {
		Diee();
		playsound2 = false;
		}
	}


	public void Diee() {
		GetComponent<AudioSource>().PlayOneShot(GameOverSound, 7.7F);			
		completeGameOverUI.gameObject.SetActive(true);
		Destroy (GameObject.FindWithTag("BackgroundMusic"));
    }
		
	void FixedUpdate() {
		
		PlayerRigidbody.AddForce (Vector2.right * forwardSpeed);

		if (playerJumped) {
			PlayerRigidbody.velocity = new Vector2 (PlayerRigidbody.velocity.x, Vector2.up.y * jumpForce);
			playerJumped = false;
		}
	}
}
