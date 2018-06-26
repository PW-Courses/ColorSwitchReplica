using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawn : MonoBehaviour {

	private Vector3 offset = new Vector3(0f, 24f, 0f);
	public GameObject fire;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "SmallCircle")
		{
			fire.transform.position = collision.transform.position;
			collision.GetComponent<SmallCircle>().SetNewPosition(offset);
		}

	}

}
