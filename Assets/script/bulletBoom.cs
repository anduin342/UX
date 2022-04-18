using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBoom : MonoBehaviour {
    public GameObject gameOBject;
    public static int score;
    public AudioClip audioclip;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
 
    void OnCollisionEnter(Collision collider)
    {
        //sc.SetActive(false);
        if ((collider.gameObject.tag == "Enemy"|| collider.gameObject.tag == "Stone" )&& gameOBject!=null)
        {
            if(collider.gameObject.tag == "Enemy")
            {
                score += 100;
            }
            
            gameOBject.transform.position = collider.transform.position;
            gameOBject.SetActive(true);
            GameObject.Instantiate(gameOBject, transform.position, transform.rotation);
            AudioSource.PlayClipAtPoint(audioclip, transform.position);
            GameObject.Destroy(gameOBject.gameObject);
            Destroy(collider.gameObject);
            Destroy(this.gameOBject);
        }

    }

}
