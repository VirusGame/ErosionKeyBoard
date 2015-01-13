using UnityEngine;
using System.Collections;

public class FinalScore : MonoBehaviour {

	public TextMesh Clear;
	public TextMesh num;
	int score = 100;
	private AudioSource audioSource;

	//public GameObject Effect;

	// Use this for initialization
	void Start () {
		Clear = GameObject.Find ("Clear").GetComponent<TextMesh> ();
		num = GameObject.Find ("Score").GetComponent<TextMesh> ();
		print (num);
		audioSource = GetComponent<AudioSource>();
		score = PlayerPrefs.GetInt ("score_tmp");
	}

	// Update is called once per frame
	void Update () {
		if (score == 100) {
			Clear.text = "GameClear!";
			//Instantiate(Effect,new Vector3(-2.4,-1.61,-1.43),Quaternion.identity);
				}
		else if(score < 100){
			Clear.text = "GameFailed";

		}
		num.text = "Erosion Rate : " + score.ToString() + "%";
		if (Input.GetKey(KeyCode.Space)){
			audioSource.PlayOneShot(audioSource.clip);
			Application.LoadLevel("Title");
		}
	}
}
