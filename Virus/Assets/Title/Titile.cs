using UnityEngine;
using System.Collections;

public class Titile : MonoBehaviour {

	private AudioSource audioSource;
	
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space)){
			audioSource.PlayOneShot(audioSource.clip);
			Application.LoadLevel("Main");
		}
	}
}
