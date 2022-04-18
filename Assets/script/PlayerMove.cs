using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {
    float rot=0;
    public GameObject effectOne;
    public GameObject effectTwo;
    public GameObject effectThree;
    public GameObject effectFour;
    public GameObject effectFive;
    public GameObject explosion;
    public AudioClip audioclip;
    public AudioClip audioclip2;
    public GameObject gameObj;
    public Text gameover;
    public Text score;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        score.text = "分数:" + bulletBoom.score;
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical1");
        rot -= Input.GetAxis("Horizontal1");
        float r = Input.GetAxis("Horizontal1");
        Vector3 dir = new Vector3(h, y, v*2);
        this.transform.position += dir;
        this.transform.rotation = Quaternion.Euler(0f, 0f, rot*2.0f);
       
        if (v >= 0.01)
        {
            AudioSource.PlayClipAtPoint(audioclip2, transform.position);
            effectOne.SetActive(true);
            effectTwo.SetActive(true);
            effectThree.SetActive(true);
        }
        else
        {     
            effectOne.SetActive(false);
            effectTwo.SetActive(false);
            effectThree.SetActive(false);
        }
        if (r >= 0.01)
        { 
            
            effectFour.SetActive(true);
        }
        else
        {
          
            effectFour.SetActive(false);
        }
        if (r <= -0.01)
        {
            
            effectFive.SetActive(true);
        }
        else
        {
           
            effectFive.SetActive(false);
        }
    }
    void OnCollisionEnter(Collision collider)
    {
        if (!this.gameObject) return;
        if (collider.gameObject.tag == "Enemy"||collider.gameObject.tag=="Stone")
        {
            gameover.text = "游戏结束";
            AudioSource.PlayClipAtPoint(audioclip, transform.position);
            GameObject.Instantiate(explosion, transform.position + Vector3.up, transform.rotation);
            Destroy(collider.gameObject);
            Destroy(this.gameObject);
            gameObj.SetActive(false);
        }
    }
}
