using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		var rotation = transform.rotation;
		rotation.y += 10;
		transform.rotation = rotation;
	}
}
