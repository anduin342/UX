using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyButtleMove : MonoBehaviour {
    public GameObject gameOBject;
    public AudioClip audioclip;
    Vector3 original;
    
    // Use this for initialization
    void Start () {
        original = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (bulletBoom.score <= 1000)
        {
            this.transform.position += new Vector3(0, 0, -2);
        }
        else
        {
            this.transform.position += new Vector3(0, 0, -4);
        }
        
        if (this.transform.position.z - original.z >= 180)
        {
            Destroy(this.gameObject);
        }
	}
    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Stone" || collider.gameObject.tag == "Play")
        {
            if (collider.gameObject.tag == "Play")
            {
                gameOBject.SetActive(true);
               // GameObject.Instantiate(gameObject,new Vector3(collider.transform.position.x, collider.transform.position.y, collider.transform.position.z+100), this.transform.rotation);
            }
            gameObject.transform.position = this.transform.position;
            GameObject.Instantiate(gameObject,this.transform.position,this.transform.rotation);
            AudioSource.PlayClipAtPoint(audioclip, transform.position);
         //   GameObject.Destroy(gameOBject.gameObject); 
            Destroy(this.gameObject);
            Destroy(collider.gameObject);
        }
    }
}
