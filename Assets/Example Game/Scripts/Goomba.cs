using UnityEngine;
using System.Collections;

public class Goomba : MonoBehaviour
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public float damage = 2;

    void OnCollisionEnter2D(Collision2D collision) {

        Debug.Log("testy boi");
        
        Player mario = collision.collider.GetComponent<Player>();
        mario.ApplyDamage(damage);
    }
}
