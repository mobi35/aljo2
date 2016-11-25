using UnityEngine;
using System.Collections;

public class other : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "magenta" && other.gameObject.tag == "red" && other.gameObject.tag == "cyan" && other.gameObject.tag == "green" && other.gameObject.tag == "blue" ) {
			Application.LoadLevel ("Gamemenu");
		
		}
	}
}
