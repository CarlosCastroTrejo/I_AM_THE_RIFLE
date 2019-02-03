using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {
    GameObject torre;
    NavMeshAgent agent;
    public int life;

    void Explote() 
    {
        Destroy(this.gameObject);
    }

    // Use this for initialization
    void Start () 
    {
        torre = GameObject.Find("CentroTorre");
        agent = this.GetComponent<NavMeshAgent>();

        if (agent == null)
        {
            Debug.Log("NavMeshAgent doesn't exist");
        }

        if (torre == null) 
        {
            Debug.Log("GameObject doesn't exist");
        }
    }
	
	// Update is called once per frame
	void Update () 
    {
        agent.SetDestination(torre.transform.position);


    }
}
