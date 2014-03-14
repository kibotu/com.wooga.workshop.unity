using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform target;
	private float xOffset; 

	void Awake () {
		xOffset = target.position.x;
	}
	
	void Update () {
		Vector3 pos = transform.position;
		pos.x = -xOffset + target.position.x;
		transform.position = pos;
	}
}