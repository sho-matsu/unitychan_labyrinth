using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class FollowUnitychan : MonoBehaviour {
	public Transform target;
	private Vector3 targetPos;

	// Use this for initialization
	void Start () {
        targetPos = target.position;
	}

	// Update is called once per frame
	void Update () {
        // ターゲットの移動分、自分も移動する
        transform.position += target.position - targetPos;
		targetPos = target.position;
        float horizontal = 0.0f;
        if (Application.platform == RuntimePlatform.Android)
        {
            //ゲーム画面に貼り付けたコントローラーからの入力
            horizontal = CrossPlatformInputManager.GetAxisRaw("Horizontal");
        }
        else
        {
            // キーボードからの入力
            horizontal = Input.GetAxis("Horizontal");
        }
        // targetの位置のY軸を中心に、回転（公転）する
        transform.RotateAround(targetPos, Vector3.up, horizontal * Time.deltaTime * 100f);
	}
}
