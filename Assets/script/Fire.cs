using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
    public AudioClip audioclip;  
    public GameObject explosion;
    public GameObject bullet2;
    public GameObject bullet1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bullet1.SetActive(true);
            bullet2.SetActive(true);
            GameObject bulletobj1 = GameObject.Instantiate(bullet1);
            GameObject bulletobj2 = GameObject.Instantiate(bullet2);
            AudioSource.PlayClipAtPoint(audioclip, transform.position);
            bulletobj1.AddComponent<bulletMove>();
            bulletobj2.AddComponent<bulletMove>();
            bulletobj1.AddComponent<BoxCollider>();
            bulletobj2.AddComponent<BoxCollider>();
            bulletobj1.AddComponent<Rigidbody>();
            bulletobj2.AddComponent<Rigidbody>();
            bulletobj1.GetComponent<Rigidbody>().useGravity = false;
            bulletobj2.GetComponent<Rigidbody>().useGravity = false;
            bulletobj1.transform.position = new Vector3(bullet1.transform.position.x, bullet1.transform.position.y, bullet1.transform.position.z + 10);
            bulletobj2.transform.position = new Vector3(bullet2.transform.position.x, bullet2.transform.position.y, bullet2.transform.position.z + 10);

        }
        else
        {
            bullet1.SetActive(false);
            bullet2.SetActive(false);
        }
    }
    //void OnCollisionEnter(Collision collider)
    //{
    //    if (collider.gameObject.tag == "Enemy")
    //    {
    //        GameObject.Instantiate(explosion, bullet1.transform.position + Vector3.up, bullet1.transform.rotation);
    //        Destroy(collider.gameObject);
    //        Destroy(this.gameObject);
    //    }
    //}
}
