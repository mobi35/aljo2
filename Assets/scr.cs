using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class scr : MonoBehaviour {
	int sd;
	int xd;
	// Use this for initialization
	void Start () {
		sd += PlayerPrefs.GetInt ("LvlScore");
	}

	// Update is called once per frame
	void Update () 
	{
		
		Debug.Log ("BURA" + sd);
	}
}
