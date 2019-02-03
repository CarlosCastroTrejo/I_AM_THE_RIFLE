 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour 
{
    public GameObject bala;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            GameObject b = Instantiate(bala, transform.position, transform.rotation) as GameObject;
            b.GetComponent<Rigidbody>().velocity = transform.forward * 8;
        
        }

    }
}
