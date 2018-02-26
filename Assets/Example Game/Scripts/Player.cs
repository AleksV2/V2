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

    public float speed = 2;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(logtext);
        Rigidbody2D erecc = GetComponent<Rigidbody2D>();
        erecc.velocity = Vector2.right*speed;
        
    }
}
