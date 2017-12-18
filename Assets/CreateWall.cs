using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWall : MonoBehaviour {
    public GameObject target;

	// Use this for initialization
	void Start () {
        this.gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        while (target.transform.position.y < 1.2F)
        {
            // todo 緩やかにせり出てくるようにしたい
            target.transform.Translate(Vector3.up * (1.2F * Time.deltaTime), Space.World);
        }
        this.gameObject.SetActive(false);
    }
}
