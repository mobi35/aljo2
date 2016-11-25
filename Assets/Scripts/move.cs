using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class move : MonoBehaviour {
	//test 
	public bool CanPause ;
	int ls;


	public int lvl1;
	//test
	public Text sc;
	public int score;
	public int lvlscore;
	public float time;
	public float shu;
	public int randomBricks;
	private int  rand;
	private int hs = 0;
	public Text hss;
	private int rs;
	public bool dead;
	public Text highScore;
	public Text yourScore;
	int aw;
	public float power1;

	//test

	int lhs;
	// Use this for initialization
	void Start () {
		power1 = 30f;
		PlayerPrefs.SetInt ("PowerOn", 0);
		CanPause = false;
		Time.timeScale = 1;
		lvlscore = PlayerPrefs.GetInt ("L1");
		//PlayerPrefs.SetInt ("L1", 0);
		//PlayerPrefs.SetInt("HS",0);
	}

	// Update is called once per frame
	public void Update()
	{	
			


		// FOR LEVEL

		//if()


		//FOR LEVEL
		if (lvlscore == 30 && Application.loadedLevelName == "lvl1") {


			StartCoroutine ("Wins");
		}

		if (lvlscore == 55 && Application.loadedLevelName == "lvl2") {

			StartCoroutine ("Wins");
		}

		if (lvlscore == 80 && Application.loadedLevelName == "lvl3") {

			StartCoroutine ("Wins");
		}


		if (lvlscore == 105 && Application.loadedLevelName == "lvl4") {

			StartCoroutine ("Wins");
		}

		if (lvlscore == 130 && Application.loadedLevelName == "lvl5") {

			StartCoroutine ("Wins");
		}

		//FOR ENDLESS THING

		if (Application.loadedLevelName == "Gameplay") {
			yourScore.text = "Your Score " + score;
			highScore.text = "High Score " + PlayerPrefs.GetInt ("HS");


			hs = score;


			time += Time.deltaTime;

			if (time > 4f) {


				randomBricks = Random.Range (1, 25);
				Instantiate (Resources.Load (randomBricks.ToString ()), new Vector3 (0f, -27.1f, 0f), transform.rotation);
				time = 0f;
		
			}

			shu += Time.deltaTime;
			power1 += Time.deltaTime;
			if (shu > 5f) {

				rand = Random.Range (1, 5);
				if (rand == 1) {
					Instantiate (Resources.Load ("obs"), new Vector3 (6f, -27.1f, 0f), transform.rotation);
				}
				if (rand == 2) {

					Instantiate (Resources.Load ("obs"), new Vector3 (3f, -27.1f, 0f), transform.rotation);
				}
				if (rand == 3) {
					Instantiate (Resources.Load ("obs"), new Vector3 (0f, -27.1f, 0f), transform.rotation);
				}
				if (rand == 4) {
					Instantiate (Resources.Load ("obs"), new Vector3 (-3f, -27.1f, 0f), transform.rotation);
				}
				if (rand == 5) {
					Instantiate (Resources.Load ("obs"), new Vector3 (-6f, -27.1f, 0f), transform.rotation);
				}
				shu = 0f;
			}

			if (power1 > 30f) {

				rand = Random.Range (1, 5);
				if (rand == 1) {
					Instantiate (Resources.Load ("powerup"), new Vector3 (6f, -27.1f, 0f), transform.rotation);
				}
				if (rand == 2) {

					Instantiate (Resources.Load ("powerup"), new Vector3 (3f, -27.1f, 0f), transform.rotation);
				}
				if (rand == 3) {
					Instantiate (Resources.Load ("powerup"), new Vector3 (0f, -27.1f, 0f), transform.rotation);
				}
				if (rand == 4) {
					Instantiate (Resources.Load ("powerup"), new Vector3 (-3f, -27.1f, 0f), transform.rotation);
				}
				if (rand == 5) {
					Instantiate (Resources.Load ("powerup"), new Vector3 (-6f, -27.1f, 0f), transform.rotation);
				}
				power1 = 0f;
			}
				

			sc.text = "Score: " + score;

			hss.text = "High Score: " + PlayerPrefs.GetInt ("HS");
		}


		// FOR LEVELING 
		if (Application.loadedLevelName == "lvl1" || Application.loadedLevelName == "lvl2" || Application.loadedLevelName == "lvl3" || 
			Application.loadedLevelName == "lvl4" || Application.loadedLevelName == "lvl5" ) {
			yourScore.text = "Your Score " + lvlscore;
			//highScore.text = "High Score " + PlayerPrefs.GetInt ("LHS");
			GameObject.Find ("L1").GetComponent<Text> ().text = "Scores: " + lvlscore;
			GameObject.Find ("HS").GetComponent<Text> ().text = "High Score: " + PlayerPrefs.GetInt("LHS");

			lhs = lvlscore;

		
			time += Time.deltaTime;



			// LEVEL 1
			if (time > 4f && ls <= 5 && Application.loadedLevelName == "lvl1") {
				

				randomBricks = Random.Range (1, 25);
				Instantiate (Resources.Load (randomBricks.ToString ()), new Vector3 (0f, -27.1f, 0f), transform.rotation);
				time = 0f;
				ls += 1;

			}
			//LEVEL 1

			// LEVEL 2
			if (time > 4f && ls <= 10 && Application.loadedLevelName == "lvl2") {
							randomBricks = Random.Range (1, 25);
				Instantiate (Resources.Load (randomBricks.ToString ()), new Vector3 (0f, -27.1f, 0f), transform.rotation);
				time = 0f;
				ls += 1;
			}
			//LEVEL 2

			// LEVEL 3
			if (time > 4f && ls <= 15 && Application.loadedLevelName == "lvl3") {
				randomBricks = Random.Range (1, 25);
				Instantiate (Resources.Load (randomBricks.ToString ()), new Vector3 (0f, -27.1f, 0f), transform.rotation);
				time = 0f;
				ls += 1;
			}
			//LEVEL 3

			// LEVEL 4
			if (time > 4f && ls <= 20 && Application.loadedLevelName == "lvl4") {
				randomBricks = Random.Range (1, 25);
				Instantiate (Resources.Load (randomBricks.ToString ()), new Vector3 (0f, -27.1f, 0f), transform.rotation);
				time = 0f;
				ls += 1;
			}
			//LEVEL 4

			// LEVEL 5
			if (time > 4f && ls <= 25 && Application.loadedLevelName == "lvl5") {

				randomBricks = Random.Range (1, 25);
				Instantiate (Resources.Load (randomBricks.ToString ()), new Vector3 (0f, -27.1f, 0f), transform.rotation);
				time = 0f;
				ls += 1;
			}
			//LEVEL 5


			Debug.Log (ls);
			shu += Time.deltaTime;
			if (shu > 5f) {

				rand = Random.Range (1, 5);
				if (rand == 1) {
					Instantiate (Resources.Load ("obs"), new Vector3 (6f, -27.1f, 0f), transform.rotation);
				}
				if (rand == 2) {

					Instantiate (Resources.Load ("obs"), new Vector3 (3f, -27.1f, 0f), transform.rotation);
				}
				if (rand == 3) {
					Instantiate (Resources.Load ("obs"), new Vector3 (0f, -27.1f, 0f), transform.rotation);
				}
				if (rand == 4) {
					Instantiate (Resources.Load ("obs"), new Vector3 (-3f, -27.1f, 0f), transform.rotation);
				}
				if (rand == 5) {
					Instantiate (Resources.Load ("obs"), new Vector3 (-6f, -27.1f, 0f), transform.rotation);
				}
				shu = 0f;
			}




		}

	}

	public void Right(){
	
		if (transform.position.x < 4) {
			transform.position += new Vector3(3, 0, 0);
		}
	}

	public void Left(){

		if (transform.position.x > -4) {
			transform.position += new Vector3(-3, 0, 0);
		}
	}



	void OnTriggerEnter2D(Collider2D other)	{

		if (transform.tag == "magenta") {
			if (other.gameObject.tag == "magentabrick" || other.gameObject.tag == "powerup" || other.gameObject.tag == "coins") {
				if (other.gameObject.tag == "coins") {
					score += 15;
					lvlscore += 15;
				}

				score += 5;
				lvlscore += 5;
				PlayerPrefs.SetInt ("L1", lvlscore);
				Destroy (other.gameObject);
			} else {
				dead = true;
				if (score > PlayerPrefs.GetInt("HS")) {
					PlayerPrefs.SetInt ("HS", hs);
				}

				if (lvlscore > PlayerPrefs.GetInt("LHS")) {

					PlayerPrefs.SetInt ("LHS", lhs);
			
				}


				StartCoroutine ("Deads");
			}
		}

		if (transform.tag == "cyan") {
			

			if (other.gameObject.tag == "cyanbrick" || other.gameObject.tag == "powerup" || other.gameObject.tag == "coins") {
				if (other.gameObject.tag == "coins") {
					score += 15;
					lvlscore += 15;
				}
				score += 5;
				lvlscore += 5;
			//	PlayerPrefs.SetInt ("LS", score);
				PlayerPrefs.SetInt ("L1", lvlscore);
				Destroy (other.gameObject);
			}else {
				
				dead = true;
				if (score > PlayerPrefs.GetInt("HS")) {

					PlayerPrefs.SetInt ("HS", hs);


				} 
				if (lvlscore > PlayerPrefs.GetInt("LHS")) {

					PlayerPrefs.SetInt ("LHS", lhs);


				} 
				StartCoroutine ("Deads");
			}
		}

		if (transform.tag == "blue") {
			

			if (other.gameObject.tag == "bluebrick" || other.gameObject.tag == "powerup" || other.gameObject.tag == "coins") {
				if (other.gameObject.tag == "coins") {
					score += 15;
					lvlscore += 15;
				}

				score += 5;
				lvlscore += 5;
			//	PlayerPrefs.SetInt ("LS", score);
				PlayerPrefs.SetInt ("L1", lvlscore);
				Destroy (other.gameObject);
			}else {
				
				dead = true;
				if (score > PlayerPrefs.GetInt("HS")) {

					PlayerPrefs.SetInt ("HS", hs);


				} 

				if (lvlscore > PlayerPrefs.GetInt("LHS")) {

					PlayerPrefs.SetInt ("LHS", lhs);


				} 
				StartCoroutine ("Deads");
			}
			}


		if (transform.tag == "green") {
			

			if (other.gameObject.tag == "greenbrick" || other.gameObject.tag == "powerup" || other.gameObject.tag == "coins") {
				if (other.gameObject.tag == "coins") {
					score += 15;
					lvlscore += 15;
				}

				score += 5;
				lvlscore += 5;

			//	PlayerPrefs.SetInt ("LS", score);
				PlayerPrefs.SetInt ("L1", lvlscore);
				Destroy (other.gameObject);
			}else {
				
				dead = true;
				if (score > PlayerPrefs.GetInt("HS")) {

					PlayerPrefs.SetInt ("HS", hs);


				} 

				if (lvlscore > PlayerPrefs.GetInt("LHS")) {

					PlayerPrefs.SetInt ("LHS", lhs);


				} 


				StartCoroutine ("Deads");
			}

		}

		if (transform.tag == "red") {
			

			if (other.gameObject.tag == "redbrick" || other.gameObject.tag == "powerup" || other.gameObject.tag == "coins") {
				if (other.gameObject.tag == "coins") {
					score += 15;
					lvlscore += 15;
				}

				score += 5;
				lvlscore += 5;
				PlayerPrefs.SetInt ("L1", lvlscore);
			//	PlayerPrefs.SetInt ("LS", score);

				Destroy (other.gameObject);
			}else {
				
				dead = true;
				if (score > PlayerPrefs.GetInt("HS")) {

					PlayerPrefs.SetInt ("HS", hs);


				} 

				if (lvlscore > PlayerPrefs.GetInt("LHS")) {

					PlayerPrefs.SetInt ("LHS", lhs);


				} 
			
				StartCoroutine ("Deads");
			}
		}
		if (other.gameObject.tag == "shuriken") 

		{
			if (score > PlayerPrefs.GetInt("HS")) {

				PlayerPrefs.SetInt ("HS", hs);
			} 
			StartCoroutine ("Deads");
		}
		}
	IEnumerator Deads()
	{
		CanPause = true;
		if(CanPause)
		{
			
			Time.timeScale=0;
			CanPause = false;
		}

		GameObject.Find ("Gameover").GetComponent<Canvas> ().enabled = true;
		PlayerPrefs.SetInt ("L1", 0);


		if(Application.loadedLevelName == "lvl2" || Application.loadedLevelName == "lvl3" || Application.loadedLevelName == "lvl4" ||
			Application.loadedLevelName == "lvl5"){
			Application.LoadLevel ("Gamemenu");
		}
		yield return new WaitForSeconds(3);

	}

	IEnumerator Wins(){
	
		CanPause = true;
		if(CanPause)
		{

			Time.timeScale=0;
			CanPause = false;
		}
		GameObject.Find ("Win").GetComponent<Canvas> ().enabled = true;
		//score = 0;
		yield return new WaitForSeconds(3);
	}


}
