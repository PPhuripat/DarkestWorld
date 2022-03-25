using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
	public AudioSource rock;
	public void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Box")
		{
			Destroy(collision.gameObject);
			rock.Play();
        }
	}
}
