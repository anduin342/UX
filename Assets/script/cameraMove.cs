using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour {
    public GameObject plan;
    Transform follow;
    private Vector3 targetPosition;
	// Use this for initialization
	void Start () {
        follow = plan.transform;
	}

    // Update is called once per frame
    void Update() {
        if (!plan) return;
        targetPosition = follow.position + Vector3.up * 10.0f - follow.forward * 20.0f;
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 10.0f);
             
    }
}
