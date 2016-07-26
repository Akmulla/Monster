using UnityEngine;
using System.Collections;

public class BonusMove : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
	// Use this for initialization
	void Awake ()
    {
        rb=GetComponent<Rigidbody2D>();
        if (transform.position.x>(Edges.leftEdge+Edges.rightEdge)/2)
        {
            speed *= -1;
        }
        rb.velocity = Vector2.right * speed;
	}

    void OnEnable()
    {
        if (transform.position.x > (Edges.leftEdge + Edges.rightEdge) / 2)
        {
            speed *= -1;
        }
        rb.velocity = Vector2.right * speed;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
