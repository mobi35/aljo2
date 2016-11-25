using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Destroy : MonoBehaviour {

	public int speed;
	float cc;
	void OnTriggerEnter2D(Collider2D other){
		
			//Destroy (this.gameObject);
		
			
	}

	void Start() {
		
		cc = 0f;
	}

	void Update(){
		
		cc += Time.deltaTime;

		speed =	GameObject.Find ("white").GetComponent<move> ().score;
		//Debug.Log (speed);

		if (speed >= 30) {
		 
			GetComponent<Rigidbody2D> ().gravityScale = -0.20f;


		}

		if (speed >= 40) {

		
			GetComponent<Rigidbody2D> ().gravityScale = -0.30f;
		}

		if (speed >= 50) {

			GetComponent<Rigidbody2D> ().gravityScale = -0.40f;
		}

		if (speed >= 60) {

			GetComponent<Rigidbody2D> ().gravityScale = -0.50f;
		}

		if (speed >= 70) {

			GetComponent<Rigidbody2D> ().gravityScale = -0.60f;
		}

		if (speed >= 80)  {

			GetComponent<Rigidbody2D> ().gravityScale = -0.70f;
	}

		if (speed >= 90) {
		
			GetComponent<Rigidbody2D> ().gravityScale = -0.80f;

		}

		if (speed >= 100) {
		
			GetComponent<Rigidbody2D> ().gravityScale = -0.15f;


			if (cc > 5f) {

				GetComponent<SpriteRenderer> ().enabled = false;
				cc = 0f;

			} 
		}

}
}