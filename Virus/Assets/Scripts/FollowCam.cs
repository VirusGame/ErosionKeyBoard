﻿using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {

	public Transform target;
	public float dist = 10.0f;
	public float height = 5.0f;
	public float dampRotate = 5.0f;
	private Transform tr;

	// Use this for initialization
	void Start () {
		tr = GetComponent<Transform> ();
	
	}

	void LateUpdate(){
		float curYangle = Mathf.LerpAngle (tr.eulerAngles.y, target.eulerAngles.y, dampRotate * Time.deltaTime);
		Quaternion rot = Quaternion.Euler (0, curYangle, 0);

		tr.position = target.position - (rot * Vector3.forward * dist) + (Vector3.up * height);

		tr.LookAt (target);
		}

	// Update is called once per frame
	void Update () {
	
	}
}
