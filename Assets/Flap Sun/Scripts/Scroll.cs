// für scrollbaren Background, habe noch keine Backgrounds


using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

	public float speed = 0;

	void Update () {
				
		GetComponent<Renderer>().material.mainTextureOffset = new Vector2((Time.time*speed)%1,0f);

	}
}
