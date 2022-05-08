using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RestartButton : MonoBehaviour {

	//Wenn Onclick = active, Game wird restarted

	public void RestartGame() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Restart the game
	}

}