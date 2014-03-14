using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public float Speed;

	void Start () {
		
	}

	void Update () {
		GetComponent<Transform>().position = Vector3.up * Time.time * Speed * Input.GetAxis("Vertical");


	}
}
