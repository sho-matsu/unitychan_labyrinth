using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStartPos : MonoBehaviour {
    public GameObject target;
    private Vector3 targetPos;

	// Use this for initialization
	void Start () {
        targetPos = target.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        target.transform.position = targetPos;
        this.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
