using UnityEngine;
using System.Collections;

public class background : MonoBehaviour {

	public float vel = 0.1f;
	
	// Update is called once per frame
	void Update () {
		Vector2 offset = new Vector2 (0,Time.time * vel);

		GetComponent<Renderer> ().material.mainTextureOffset = offset;
	}
}
