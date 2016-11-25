using UnityEngine;
using System.Collections;

public class Timing : MonoBehaviour {

	public int timing;
	public float count;
	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
		timing = PlayerPrefs.GetInt ("PowerOn");
		if (timing == 1) {
			count += Time.deltaTime;
			if (count >= 8f) {
				Debug.Log ("Eww");
				PlayerPrefs.SetInt ("PowerOn", 0);
				GameObject.Find("obs(Clone)").GetComponent<Transform>().tag = "shuriken";
			}
		
		}
	}

}
