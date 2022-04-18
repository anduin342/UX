using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour {
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;
    public GameObject enemy7;
    public GameObject enemy8;
    public GameObject player;
    List<GameObject> Enemylist;
    // Use this for initialization
    void Start () {
        Enemylist = new List<GameObject>();
        Enemylist.Add(enemy1);
        Enemylist.Add(enemy2);
        Enemylist.Add(enemy3);
        Enemylist.Add(enemy4);
        Enemylist.Add(enemy5);
        Enemylist.Add(enemy6);
        Enemylist.Add(enemy7);
        Enemylist.Add(enemy8);
    }
    int i = 0;
	// Update is called once per frame
	void Update () {

        i++;
        if (i>100&&player)
        {
            i = 0;
            int NameNum = Random.Range(0, 8);
            GameObject EnemyObj = GameObject.Instantiate(Enemylist[NameNum]);
            EnemyObj.transform.position = player.transform.position + new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(150, 250));
            EnemyObj.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            EnemyObj.AddComponent<StoneMove>();
            EnemyObj.gameObject.tag = "Enemy";      
            Destroy(EnemyObj, 10);
        }
	}
    
}
