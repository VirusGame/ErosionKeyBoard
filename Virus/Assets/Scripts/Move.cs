using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float v = 0;
	public float h = 0;
	public float speed = 10;
	public float rotSpeed = 100;
	private Transform tr;

	// Use this for initialization
	void Start () {
		tr = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		h = Input.GetAxis("Horizontal");
		v = Input.GetAxis("Vertical");

		Vector3 move = (Vector3.up * v) + (Vector3.right * h);

		tr.Translate (move * Time.deltaTime * speed, Space.World);
		tr.Rotate(Vector3.up * rotSpeed * Time.deltaTime * Input.GetAxis("Mouse X"));
	
	}
}
