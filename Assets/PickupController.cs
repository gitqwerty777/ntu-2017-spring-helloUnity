using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public float RotateSpeed;

	// Update is called once per frame
	void Update () {

		this.transform.localEulerAngles += new Vector3 (0,0,RotateSpeed*Time.deltaTime);
		
	}
}
