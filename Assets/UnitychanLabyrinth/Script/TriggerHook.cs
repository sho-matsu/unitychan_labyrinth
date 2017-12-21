using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHook : MonoBehaviour {
    public GameObject target;

	// Use this for initialization
	void Start () {
        this.gameObject.SetActive(true);
        target.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        target.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
