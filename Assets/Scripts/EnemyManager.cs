using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
    public GameObject AssetBase;

    void CreateEnemies() 
    {
        GameObject enemy = Instantiate(AssetBase,this.transform.position, Quaternion.identity);
        enemy.transform.parent = this.transform;
    }

    // Use this for initialization
    void Start () 
    {
        InvokeRepeating("CreateEnemies", 2, 6);
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}
}
