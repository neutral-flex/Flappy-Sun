using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BackToMenuButton : MonoBehaviour {

	//onlclick = active, zurück zu Menu 

	public void BackToMenuGame() {
		SceneManager.LoadScene(0); //Lädt aktuelle Szene 0 welche das Main Menu ist
	}
}
