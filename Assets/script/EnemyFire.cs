using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public AudioClip audioclip;
    public GameObject explosion;
    public GameObject bullet;
   
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    int i = 0;
    void Update()
    {

        i++;
        if (i > 100)
        {
            i = 0;
            if (bullet)
            {
                bullet.SetActive(true);
            }
            GameObject bulletObj=  GameObject.Instantiate(bullet);
            AudioSource.PlayClipAtPoint(audioclip, transform.position);
            bulletObj.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z -20);
            
        }
      
    }
}
