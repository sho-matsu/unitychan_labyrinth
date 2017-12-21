using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRising : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < 1.3F) {
            transform.Translate(Vector3.up * 2.0F * Time.deltaTime, Space.World);
        }
	}
}
