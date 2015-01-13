using UnityEngine;
using System.Collections;

public class MapCamera : MonoBehaviour
{
	Animator animator;
	public Score Flag;

	GameObject playerr;
	public GameObject aa;
	int s = 0;
	void Start ()
	{
		animator = GetComponent<Animator> ();
		playerr = GameObject.Find ("Player");
	}
	
	void Update ()
	{
		Score isFin = playerr.GetComponent<Score>();
		if (isFin.isFinish_ == true) {
			animator.SetBool ("isFinished", true);
			Invoke("MoveResult2",3.28f); 

		} else {
			animator.SetBool ("isFinished", false);
			//Debug.Log("isfinish is false");
		}
	
	}
	public void MoveResult2(){
		s = aa.GetComponent<Score>().score;
		PlayerPrefs.SetInt ("score_tmp", s);
		Application.LoadLevel ("GameOver");
	}


}
