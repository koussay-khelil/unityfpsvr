using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MyShootingScript : MonoBehaviour {

    // Use this for initialization
    public Camera fpscamera;
    public Transform gunbarrel;
    public float range = 100f;
    public float damage = 15f;
    public GameObject impacteffect;
    public AudioSource sound;
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
      /* if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }*/
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            shoot();
        }

    }
    void shoot ()
    {
        sound.Play();
        RaycastHit hit;
        if (Physics.Raycast(fpscamera.transform.position, gunbarrel.transform.forward, out hit, range))
        {

            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);

            }


            GameObject impactgo=   Instantiate(impacteffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactgo, 2f);
        }
    }
}
