using UnityEngine;
using System.Collections;

public class Obs_Anim : MonoBehaviour {

	public int idx;
	Animator animator;
	public AnimationClip move1, move2, move3, move4;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		StartCoroutine("Animation_Trans");
	}

	IEnumerator Animation_Trans(){

		while (true) {
						idx = (int)(Random.Range (0, 360) % 4);

						switch (idx) {
						case 0:
								animator.SetBool ("Move1", true);
								yield return new WaitForSeconds (move1.length);
								animator.SetBool ("Move1", false);
								break;
			
						case 1:
								animator.SetBool ("Move2", true);
								yield return new WaitForSeconds (move2.length);
								animator.SetBool ("Move2", false);
								break;
			
						case 2:
								animator.SetBool ("Move3", true);
								yield return new WaitForSeconds (move3.length);
								animator.SetBool ("Move3", false);
								break;
			
						case 3:
								animator.SetBool ("Move4", true);
								yield return new WaitForSeconds (move4.length);
								animator.SetBool ("Move4", false);
								break;
						}
				}
		}


	
	// Update is called once per frame
	void Update () {
	
		}
	
}




