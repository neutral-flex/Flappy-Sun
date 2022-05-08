using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class ExitButton : MonoBehaviour {

	//Wenn onclick = active, Game wird geschlossen

	public void ExitGame() {
		Application.Quit(); //Exit the game
	}
}
