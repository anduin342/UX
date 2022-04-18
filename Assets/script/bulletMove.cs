using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMove : MonoBehaviour {
    
    Vector3 original;
	// Use this for initialization
	void Start () {

        original = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += new Vector3(0, 0, 3);
        if (this.transform.position.z - original.z >= 250)
        {
            Destroy(this.gameObject);
        }

	}
   
}
