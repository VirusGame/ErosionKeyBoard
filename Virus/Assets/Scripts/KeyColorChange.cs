using UnityEngine;
using System.Collections;

public class KeyColorChange : MonoBehaviour {

	private GameObject ParentObject;
	public Material VirusA;

	// Use this for initialization
	void Start () {
		
		ParentObject = gameObject.transform.parent.gameObject; //Get "Key ~" Object

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.collider.tag == "Player") {
			ParentObject.gameObject.renderer.material = VirusA;
		}
	}

}
