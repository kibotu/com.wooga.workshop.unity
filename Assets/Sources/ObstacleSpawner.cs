using UnityEngine;
using System.Collections;

public class ObstacleSpawner : MonoBehaviour {

	public GameObject Obstacle;
	public float distance;
	public int numOfObstacles;

	void Start () {
		for (int i = 0; i < numOfObstacles; ++i) {
			var go = (GameObject)Instantiate (Obstacle) as GameObject;
			var pos = Vector2.right * (i * Random.Range(distance, 1.5f * distance));
			pos.x += transform.position.x;
			pos.y = Utiliy.Range(-1f, 1f, -1.2f, 7.2f);
			go.transform.position = pos;
			go.transform.parent = transform;
		}
	}
}
