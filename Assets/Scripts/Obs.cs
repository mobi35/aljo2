using UnityEngine;
using System.Collections;
public class Obs : MonoBehaviour {
	public int ifPowered;
	public Sprite coin;
	public Sprite blocks;
	public float timing;
	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void FixedUpdate () {
		//ifPowered = 3;
	}
	void Update() {

		if (transform.tag == "coins") {
			GetComponent<SpriteRenderer> ().sprite = coin;
		} 

		if (transform.tag == "shuriken") {
			GetComponent<SpriteRenderer> ().sprite = blocks;
		}




		ifPowered = PlayerPrefs.GetInt ("PowerOn");
		if (ifPowered == 1) {
			timing += Time.deltaTime;
			transform.tag = "coins";

			}
		}

}
