﻿using UnityEngine;
using System.Collections;

public class OctopusBehaviour : MonoBehaviour {
    public float moveSpeed = 3f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * moveSpeed);
    }
}
