using UnityEngine;
using System.Collections;

public class a : MonoBehaviour {

	public bool CanPause ;
	Color[] colors = new Color[] {Color.magenta, Color.blue, Color.green, Color.red, Color.cyan};
	private int currentColor,length;

	// Use this for initialization
	void Start () {
		currentColor = 0;
		length = colors.Length;
		GetComponent<Renderer>().material.color = colors[currentColor];
		CanPause = true;
	
}
	// Update is called once per frame
	void Update () {
		


	if(Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit,100))
			{
				currentColor = (currentColor+1)%length;
				GetComponent<Renderer>().material.color = colors[currentColor];
			}
	}
		if (currentColor == 0) {
			Debug.Log ("Magenta");
			transform.tag = "magenta";
		}

		if (currentColor == 1) {
			Debug.Log ("blue");
			transform.tag = "blue";
		}

		if (currentColor == 2) {
			Debug.Log ("green");
			transform.tag = "green";
		}

		if (currentColor == 3) {
			Debug.Log ("red");
			transform.tag = "red";
		}

		if (currentColor == 4) {
			Debug.Log ("cyan");
			transform.tag = "cyan";
		}

}
}