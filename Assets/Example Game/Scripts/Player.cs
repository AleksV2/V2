using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Debug.Log(logtext);
    }
    public string logtext = "kill me pls";
    public float health = 10;
    public float speed = 2;

    
    // Update is called once per frame
    void Update()
    {
        
        Rigidbody2D erecc = GetComponent<Rigidbody2D>();
        erecc.velocity = Vector2.right*speed;


        
    }

    public void ApplyDamage(float DamageToDeal)
    {
        health = health - DamageToDeal;
    }
}
