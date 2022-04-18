using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    public GameObject Explosion;
    public AudioClip audioclip;
    int Movenum = 0;
    // Use this for initialization
    void Start()
    {
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
    void Update()
    {
        if (!this.gameObject) return;
        this.transform.position += new Vector3(0, 0, Movenum) * Time.deltaTime;
    }
    void OnCollisionEnter(Collision collider)
    {
        //sc.SetActive(false);
        if (collider.gameObject.tag == "Stone" || collider.gameObject.tag == "Play")
        {
            if (audioclip)
            {
                AudioSource.PlayClipAtPoint(audioclip, transform.position);
            }   
            GameObject.Instantiate(Explosion, transform.position + Vector3.up, transform.rotation);
            Destroy(collider.gameObject);
            Destroy(this.gameObject);
        }
    }
}
