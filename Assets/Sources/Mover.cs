using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public float Speed;

	void Start () {
		
	}

	void OnGizmo() {
		Debug.DrawRay (transform.position, transform.up, Color.green);
		Debug.DrawRay (transform.position, transform.forward, Color.blue);
	}

	void Update () {
		GetComponent<Transform>().position = Vector3.up * Time.time * Speed * Input.GetAxis("Vertical");
	}
}
