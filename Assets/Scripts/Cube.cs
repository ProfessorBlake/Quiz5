using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : MonoBehaviour
{
	public bool Spin;
	public bool Move;
	public Text LapsText;

	private int laps = 0;

	public void ToggleSpin(bool spin)
	{
		Spin = spin;
	}

	public void ToggleMove(bool move)
	{
		Move = move;
	}

	private void Update()
	{
		if(Spin)
		{
			transform.Rotate(new Vector3(10f, 40f, 100f) * Time.deltaTime);
		}
		if(Move)
		{
			transform.position += new Vector3(Time.deltaTime * 8f, 0f, 0f);
			if (transform.position.x > 10f)
			{
				transform.position = new Vector3(-10f, transform.position.y, transform.position.z);
				laps++;
				LapsText.text = "I've done " + laps + " laps!";
			}
		}
	}
}
