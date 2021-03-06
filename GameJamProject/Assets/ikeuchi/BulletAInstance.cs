﻿using UnityEngine;
using System.Collections;

public class BulletAInstance : MonoBehaviour {

	
	
	[SerializeField]
	private GameObject Prefab = null;

	public float Posx = 0;
	public float Posy = 0;
	
	public int typeShot = 0;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z)) {
			typeShot = GameObject.Find("BulletRoot").GetComponent<typeMode>().type;
			Posx = GameObject.Find("BulletRoot").GetComponent<typeMode>().Posx;
			Posy = GameObject.Find("BulletRoot").GetComponent<typeMode>().Posy;

			if (typeShot == 0) {
				var clone = (GameObject)Instantiate (Prefab);
				clone.transform.position = new Vector3 (Posx, Posy, 0.0f);
				clone.transform.SetParent (this.transform);
			}
		}
	}
}
