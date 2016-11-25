using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {
	string n;
	// Use this for initialization
	void Start () {
		
		//LoadLevel (n);
	}
	
	// Update is called once per frame
	void Update () {


	}
	public void Loads(string nams) {
		Application.LoadLevel (nams);

	}

	public void LoadLevel()
	{
		n =	Application.loadedLevelName;
		Application.LoadLevel (n);
	}

	public void LevelManage() {
				if (Application.loadedLevelName == "lvl1") {
					Application.LoadLevel ( "lvl2");
				}

		if (Application.loadedLevelName == "lvl2") {
			Application.LoadLevel ( "lvl3");
		}

		if (Application.loadedLevelName == "lvl3") {
			Application.LoadLevel ( "lvl4");
		}

		if (Application.loadedLevelName == "lvl4") {
			Application.LoadLevel ( "lvl5");
		}

	}

}
