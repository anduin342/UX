using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMove : MonoBehaviour {
    int Movenum = 0;
	// Use this for initialization
	void Start () {     
        if (bulletBoom.score <= 500)
        {
            Movenum = Random.Range(-40, -20);
        }
        else
        {
            Movenum = Random.Range(-160, -80);
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (!this.gameObject) return;
        this.transform.position += new Vector3(0, 0, Movenum)*Time.deltaTime;
	}
}
