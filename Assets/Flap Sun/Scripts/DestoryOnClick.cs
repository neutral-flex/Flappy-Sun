// Wenn Spieler Maustaste drückt, wird gameobject destroyed

using UnityEngine;
using System.Collections;

public class DestoryOnClick : MonoBehaviour {
	
	void Update () {

		if (Input.GetMouseButtonDown(0))
		{
			Destroy (gameObject);
	}
  }
}
