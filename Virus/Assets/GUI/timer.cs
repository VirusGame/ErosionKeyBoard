using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {
	public TextMesh timer_mesh;
	public float time = 300.0f;
	int timescore_tmp = 0;
	public Score scoretmp;

	float timetmp = 0.0f;

	GameObject playerr;
	// Use this for initialization
	void Start () {
		timer_mesh = GameObject.Find ("timer").GetComponent<TextMesh> ();
		playerr = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		timetmp += Time.deltaTime;
		if (timetmp >= 2.5f) {
						time -= Time.deltaTime;
						if (time <= 0.0f) {
								time = 0.0f;

								Score S = playerr.GetComponent<Score> ();
								S.ScoreSender ();

								S.isFinish_ = true;

								//timescore_tmp = scoretmp.score;
								//Debug.Log("time_score");
								//PlayerPrefs.SetFloat("timescore_tmp",scoretmp.score);
				
						}
						//Debug.Log ("time");
						//time = Math.Floor(time % 60f);
						timer_mesh.text = time.ToString ("f0");
				}
	}
}
