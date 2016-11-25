using UnityEngine;
using System.Collections;

public class powerup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "magenta" || other.gameObject.tag == "blue" || 
			other.gameObject.tag == "green" || other.gameObject.tag == "red" || 
			other.gameObject.tag == "cyan" ) {
			PlayerPrefs.SetInt ("PowerOn",1);
		}
	}
}
