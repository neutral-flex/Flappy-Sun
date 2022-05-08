using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopGenerator : MonoBehaviour {

	public playerScript player;
	public GameObject[] obstaclePrefab;

	private GameObject obstacle1;
	private GameObject obstacle2;
	private GameObject obstacle3;
	private GameObject obstacle4;

	public float minObstacleY;
	public float maxObstacleY;

	public static HoopGenerator instance;
    private void Awake()
    {
		instance = this;
    }
    void Start () {

		//erstelle die Ringe
		obstacle1 = GenerateObstacle (player.transform.position.x + 5);
		obstacle2 = GenerateObstacle (obstacle1.transform.position.x);
		obstacle3 = GenerateObstacle (obstacle2.transform.position.x);
		obstacle4 = GenerateObstacle (obstacle3.transform.position.x);
	}

	GameObject GenerateObstacle(float x)
	{
		//generiert die Ringe
		GameObject obstacle;
		obstacle = Instantiate (obstaclePrefab[Random.Range(0, obstaclePrefab.Length)], Vector3.zero, Quaternion.identity) as GameObject;

		
		SetTransform (obstacle, x);
		return obstacle;
	}

	void SetTransform(GameObject obstacle, float x)
	{
		obstacle.transform.position = new Vector3 (x + 6f, Random.Range (minObstacleY, maxObstacleY), obstacle.transform.position.z);
	}

	void Update () {
		// updaten von aktuellen Ringen
		if (player.transform.position.x > obstacle2.transform.position.x) {
			var tempObstacle = obstacle1;
			obstacle1 = obstacle2;
			obstacle2 = obstacle3;
			obstacle3 = obstacle4;

			SetTransform (tempObstacle, obstacle3.transform.position.x);
			obstacle4 = tempObstacle;
		}
	}
}
