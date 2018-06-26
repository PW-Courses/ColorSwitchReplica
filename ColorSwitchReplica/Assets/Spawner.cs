using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject colorSwitch;
	private Vector3 currentPosition;

	private Vector3 offset = new Vector3(0f, 6f, 0f);

	// Use this for initialization
	void Start()
	{
		currentPosition = new Vector3(0f, 5f, 0f);
	}
	// Update is called once per frame
	void Update () {
			
	}

	public void SpawnNewOne()
	{
		GameObject newCS = Instantiate(colorSwitch, currentPosition + offset, Quaternion.identity) as GameObject;
		currentPosition = newCS.transform.position;
	}
}
