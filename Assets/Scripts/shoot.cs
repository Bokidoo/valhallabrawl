﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

    public GameObject pinselPrefab;
    public Transform pinselSpawn;
	public int player = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player == 0 && Input.GetButton("Fire1p1"))
		{
			fire();
		}
		else if (player == 1 && Input.GetButton("Fire1p2"))
        {
            fire();
        }
    }
    private void fire()
    {
        var pinsel = (GameObject)Instantiate(pinselPrefab,
        pinselSpawn.position,
        pinselSpawn.rotation);
        //Add velocity to the pinsel
        pinsel.GetComponent<Rigidbody>().velocity = pinsel.transform.forward * 60;
        //Destroy the pinsel
        Destroy(pinsel, 5.0f);
    }
}
