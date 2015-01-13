using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public Transform[] points;
	public GameObject Snack;
	public float spawnTime = 2.0f;
	public int maxSnack = 5;

	// Use this for initialization
	void Start () {
		points = GameObject.Find ("SpawnSnack").GetComponentsInChildren<Transform> ();

		if (points.Length > 0) {
			StartCoroutine(CreateSnack());		
		}
	}

	IEnumerator CreateSnack(){
				while (true) {
						int snackCount = (int)GameObject.FindGameObjectsWithTag ("Snack").Length;

						if (snackCount <= maxSnack) {
								yield return new WaitForSeconds (spawnTime);

								int idx = Random.Range (1, points.Length);
								Instantiate (Snack, points [idx].position, points [idx].rotation);
						} else {
								yield return null;
						}
				}
		}
}
