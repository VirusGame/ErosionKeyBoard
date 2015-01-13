using UnityEngine;
using System.Collections;

public class KeyColorChange : MonoBehaviour {

	private GameObject ParentObject;
	public Material VirusA;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		
		ParentObject = gameObject.transform.parent.gameObject; //Get "Key ~" Object
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.collider.tag == "Player") {
			audioSource.PlayOneShot(audioSource.clip);
			ParentObject.gameObject.renderer.material = VirusA;
		}
	}

}
