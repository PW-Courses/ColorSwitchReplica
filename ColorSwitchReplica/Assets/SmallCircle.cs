using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallCircle : MonoBehaviour {

	public float rotateSpeed = 100f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
	}

	public void SetNewPosition(Vector3 offset)
	{
		transform.position = transform.position + offset;
	}
}
