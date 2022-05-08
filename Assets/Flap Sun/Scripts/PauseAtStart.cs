//Script wird dafür benutzt, um Szene zu pausieren, damit Sie nicht direkt startet,
//erst wenn man die Maustaste benutzt und irgendwo auf den Screen drückt startet das Spiel.

using UnityEngine;
using System.Collections;

public class PauseAtStart : MonoBehaviour {
	
	public AudioClip StartSound;
	
	void Start () {
		isStartButtonPressed = false;
		Time.timeScale = 0.0f;
	}
	
	private bool isStartButtonPressed;
	void OnGUI()
	{
		if (!isStartButtonPressed)
		{
			if(Input.anyKeyDown)
			{
				GetComponent<AudioSource>().PlayOneShot(StartSound, 7.7F);
				Time.timeScale = 1.0f;
				isStartButtonPressed = true;
			}
		}
	}
}