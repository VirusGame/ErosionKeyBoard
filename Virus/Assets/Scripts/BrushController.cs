using UnityEngine;
using System.Collections;

public class BrushController : MonoBehaviour {

	public GameObject explosion;
	public bool flag = false;
	public int score_tmp = 0;
	int scoredeath;
	GameObject playerr;

	// Use this for initialization
	void Start () {
		playerr = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
				if (col.gameObject.tag == "Obstacle") {

						if (flag == false) {
								Destroy (gameObject);
								Object obj = Instantiate (explosion, transform.position, transform.rotation);
								Destroy (obj, 1.0f);
								scoredeath = playerr.GetComponent<Score> ().score;

								PlayerPrefs.SetInt ("score_tmp", scoredeath);
								Application.LoadLevel ("GameOver");

						}
				}

				if (col.gameObject.tag == "Snack") {
						Destroy (col.gameObject);
						StartCoroutine ("Invincible");
				}
		}

	IEnumerator Invincible(){
				flag = true;
				(GetComponent ("Halo") as Behaviour).enabled = true;
				yield return new WaitForSeconds (10.0f);
				(GetComponent ("Halo") as Behaviour).enabled = false;
				flag = false;
		}
}
