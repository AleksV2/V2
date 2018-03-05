using UnityEngine;
using System.Collections;

public class EnemyBase : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public float damage = 2;

	void OnCollisionEnter2D(Collision2D collision) {

		Debug.Log("testy boi");

		Riley mario = collision.collider.GetComponent<Riley>();
		if (mario != null)
		{
			mario.ApplyDamage(damage);
		}

	}
}
