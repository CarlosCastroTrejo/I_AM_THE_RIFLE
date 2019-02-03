using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {
    GameObject torre;
    NavMeshAgent agent;
    GameObject[] hiddenSpots;
    GameObject theSpot;
    public int lifeEnemy;

   

    // Use this for initialization
    void Start () 
    {
        torre = GameObject.Find("CentroTorre");
        agent = this.GetComponent<NavMeshAgent>();
        hiddenSpots = GameObject.FindGameObjectsWithTag("Spots");

        if (agent == null)
        {
            Debug.Log("NavMeshAgent doesn't exist");
        }


        if (torre == null) 
        {
            Debug.Log("GameObject doesn't exist");
        }

        if (hiddenSpots == null)
        {
            Debug.Log("HiddenSpots don't exist");
        }
        else
        {
            int number = (System.DateTime.Now.Hour+ Random.Range(0, hiddenSpots.Length))%hiddenSpots.Length;
            theSpot = hiddenSpots[number];
        }

        Invoke("GoHidden",1);
    }
	
	// Update is called once per frame
	void Update () 
    {
        if ((theSpot.transform.position - this.transform.position).magnitude <= 1.2f)
        {
            Invoke("GoAttack", 6);
        }
        if (lifeEnemy <= 0)
        {
            Destroy(gameObject);
        }

    }

    private void GoHidden()
    {
        agent.SetDestination(theSpot.transform.position);
        
    }

    private void GoAttack()
    {
        agent.SetDestination(torre.transform.position);
    }


    // Use this to check of the bullet has already hit the enemy
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            lifeEnemy -= 50;
        }
        if (other.gameObject.CompareTag("Torre"))
        {
            Destroy(gameObject);
        }
    }

   
}
