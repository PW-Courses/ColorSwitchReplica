using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Spawner spawner;

	private Rigidbody2D myRB;
	private string myCurrentColor;

	public SpriteRenderer mySprite;
	public Color[] colors;

	public float jumpForce;

	// Use this for initialization
	void Start () {
		myRB = GetComponent<Rigidbody2D>();

		SetRandomColor();
	}

	// Update is called once per frame
	void Update() {

		if (Input.GetMouseButtonDown(0))
		{
			myRB.velocity = Vector2.up * jumpForce;
		}
	}

	public void SetRandomColor()
	{
		int randomC = Random.Range(0, 4);

		switch(randomC)
		{
			case 0:
				SetNewColor("Cyan", 0);
				break;
			case 1:
				SetNewColor("Yellow", 1);
				break;
			case 2:
				SetNewColor("Magenta", 2);
				break;
			case 3:
				SetNewColor("Pink", 3);
				break;
		}
	}

	void SetNewColor(string newColor, int colorIndex)
	{
		if (myCurrentColor != newColor)
		{
			myCurrentColor = newColor;
			mySprite.color = colors[colorIndex];
		}
		else
			SetRandomColor();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "ColorSwitch")
		{
			SetRandomColor();
			Destroy(collision.gameObject);
			spawner.SpawnNewOne();
			return;
		}

		if (collision.tag != myCurrentColor)
		{
			print("u ded");
		}
	}
}
