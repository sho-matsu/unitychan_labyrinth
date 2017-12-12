using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRotation : MonoBehaviour {
    public int speed;
    private Vector3 defPos;

	// Use this for initialization
	void Start () {
        defPos = transform.position;
	}

	// Update is called once per frame
	void Update () {
        transform.position = defPos;
        var rotation = transform.rotation;
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
	}
}
