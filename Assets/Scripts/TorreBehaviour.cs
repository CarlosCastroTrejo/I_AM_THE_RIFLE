using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorreBehaviour : MonoBehaviour {
    public static int lifeTower;

	// Use this for initialization
	void Start () {
        lifeTower = 100;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (lifeTower <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            lifeTower -= 5;
        }
    }
}
