using UnityEngine;
using System.Collections;

public class ColorChanger : MonoBehaviour {

	public Color Color;
	private Color defaultColor;

	public void Awake() {
		defaultColor = renderer.material.color;
	}

	void Start () {
		// renderer.materials [0].color = Color.blue;
		//renderer.materials [0].SetColor ("_Color", Color.blue);
	}
	
	void Update () {
	}

	public void OnMouseDown() {
		renderer.material.color = Color;
	}

	public void OnMouseUp() {
		renderer.material.color = defaultColor;
	}
}
