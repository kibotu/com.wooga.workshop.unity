using UnityEngine;
using System.Collections;

public class DrawDebugRays : MonoBehaviour {

	void Update () {
		Debug.DrawRay (transform.position, transform.up, Color.green);
		Debug.DrawRay (transform.position, transform.forward, Color.blue);
	}
}
