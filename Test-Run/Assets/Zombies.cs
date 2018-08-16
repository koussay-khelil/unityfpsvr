using UnityEngine.AI;
using UnityEngine;
using Unity.Collections;

public class Zombies : MonoBehaviour {
    Animator anim;
    NavMeshAgent navigator;
    GameObject play;
    public GameObject zombie;


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        navigator = GetComponent<NavMeshAgent>();
        anim.Play("walk");
        play = GameObject.FindGameObjectWithTag("MainCamera");
        
        

	}
	
	// Update is called once per frame
	void Update () {


        Transform goal = play.transform;

        navigator.destination = goal.position;
        
        if (Vector3.Distance(zombie.transform.position, play.transform.position) > 2)
        {
            anim.Play("walk");
        }
        else
        {
            if (Vector3.Distance(zombie.transform.position, play.transform.position) <= 2)
            {

                anim.SetInteger("Distance", 1);
            }
        }






        if (Time.deltaTime > 20)
            Destroy(this.gameObject);
	}
}
