using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	GameObject player;
	GameObject snack;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		snack = GameObject.Find ("Snack");
	}

	//if player get snack, he becomes matchless 10 second

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider coll){
		if(coll.collider.tag == "Snack"){
			Destroy(snack);
			print ("destroy");
			renderer.material.color = Color.green;
			Invoke("FinMatchless",1);
			//Debug.Log("Collision!");
		}
	}

	void FinMatchless(){
		renderer.material.color = Color.blue;
	}
}
