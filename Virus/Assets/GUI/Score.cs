using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
	public TextMesh num;
	public int score = 0;
	public int score_tmp = 0;
	GameObject player;
	public float key_num;
	public timer TimeCount;
	public bool isFinish_ = false;
	
	void Start ()
	{
		num = GameObject.Find ("num").GetComponent<TextMesh> ();
		player = GameObject.Find ("Player");
	}

	void Update ()
	{
		if (score >= 100) {
			//ScoreSender ();
			score = 100;
			num.text = score.ToString ();

			isFinish_ = true;

			//PlayerPrefs.SetInt ("score_tmp", score);
			//Application.LoadLevel ("GameOver");
		}
	}

	void OnTriggerEnter (Collider coll)
	{
		if (coll.collider.tag == "score_col") {
			Destroy (coll);
			//Debug.Log("Collision!");
			score += (int)(1 / key_num * 100);
			num.text = score.ToString ();
		}
	}
	
	public void ScoreSender ()
	{
	
		if (this.score >= 100) {
			this.score = 100;
			num.text = score.ToString ();

			isFinish_ = true;
			Invoke("MoveResult",3.28f);
			//PlayerPrefs.SetInt ("score_tmp", score);
			//Application.LoadLevel ("GameOver");
		} 

		if (TimeCount.time <= 0.0f) {
			//Debug.Log("aaa");
			num.text = score.ToString ();

			isFinish_ = true;
			Invoke("MoveResult",3.28f);
			//PlayerPrefs.SetInt ("score_tmp", score);
			//Application.LoadLevel ("GameOver");
		}
	}
	public void MoveResult(){
		PlayerPrefs.SetInt ("score_tmp", score);
		Application.LoadLevel ("GameOver");
	}
}