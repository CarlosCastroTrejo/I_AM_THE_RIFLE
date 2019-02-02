using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {
    GameObject torre;
    float distance;

    void Explote() 
    {
        Destroy(this.gameObject);
    }

    // Use this for initialization
    void Start () 
    {
        torre = GameObject.Find("Torre");
        if (torre == null) 
        {
            Debug.Log("GameObject doesn't exist");
        }
    }
	
	// Update is called once per frame
	void Update () 
    {
        Vector3 dir = torre.transform.position - this.transform.position;
        this.transform.position = this.transform.position + dir * Time.deltaTime*.1f;
        Quaternion q = Quaternion.LookRotation(dir);
        transform.rotation = q;
        if (Vector3.Distance(torre.transform.position, this.transform.position) <=4.4f) 
        {
            Explote();
        }


    }
}
