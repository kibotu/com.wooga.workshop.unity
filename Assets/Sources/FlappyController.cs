using UnityEngine;
using System.Collections;

public class FlappyController : MonoBehaviour {

	public float UpForce;
	public float Speed;
	public GameObject Explosion;

	void Awake() {
		rigidbody2D.velocity = Vector2.zero;
	}

	void Start () {
		rigidbody2D.velocity = Vector2.right *  Speed;
	}
	
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			rigidbody2D.AddForce(Vector2.up * Time.time * UpForce);
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		var go = Instantiate(Explosion) as GameObject;
		go.transform.position = transform.position;
		gameObject.GetComponentInChildren<Renderer>().enabled = false;
		gameObject.SetActive (false);
		Invoke("RestartLevel", 2f);
	}
	
	void RestartLevel() {
		Application.LoadLevel(0);
	}
}
