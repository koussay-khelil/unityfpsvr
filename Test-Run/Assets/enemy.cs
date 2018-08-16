using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour {
   public Transform player;


    NavMeshAgent finder;
    
	// Use this for initialization
	void Start () {
        //player = GameObject.FindGameObjectsWithTag("Player").transform;


        finder = GetComponent<NavMeshAgent>();

		
	}
	
	// Update is called once per frame
	void Update () {



        finder.SetDestination(player.position);
		
	}
}
