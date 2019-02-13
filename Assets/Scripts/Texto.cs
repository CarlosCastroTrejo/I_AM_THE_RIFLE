using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Texto : MonoBehaviour {

    public Text vidaTorre;

     
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        vidaTorre.text = "Tower's Life: " + TorreBehaviour.lifeTower; 
		
	}
}
