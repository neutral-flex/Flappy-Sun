using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ContinueButton : MonoBehaviour {

	//Wenn Onclick = active wird die nächste Szene geladen

	public void ContinueGame() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
