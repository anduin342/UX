using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {
    public GameObject stone1;
    public GameObject stone2;
    public GameObject stone3;
    public GameObject stone4;
    public GameObject stone5;
    public GameObject stone6;
    public GameObject stone7;
    public GameObject stone8;
    public GameObject player;
    List<GameObject> Stonelist;
    // Use this for initialization
    void Start () {
        Stonelist = new List<GameObject>();
        Stonelist.Add(stone1);
        Stonelist.Add(stone2);
        Stonelist.Add(stone3);
        Stonelist.Add(stone4);
        Stonelist.Add(stone5);
        Stonelist.Add(stone6);
        Stonelist.Add(stone7);
        Stonelist.Add(stone8);
        
    }
    int i = 0;
	// Update is called once per frame
	void Update () {
        i++;
        if (i >= 15&&player)
        {
            i = 0;
            int NameNum = Random.Range(0, 8);
            GameObject StoneObj = GameObject.Instantiate(Stonelist[NameNum]);
            StoneObj.transform.position = player.transform.position + new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(150, 250));
            StoneObj.AddComponent<StoneMove>();
            StoneObj.AddComponent<BoxCollider>();
            StoneObj.gameObject.tag = "Stone";
            Destroy(StoneObj, 10);
        }
	}
} 
