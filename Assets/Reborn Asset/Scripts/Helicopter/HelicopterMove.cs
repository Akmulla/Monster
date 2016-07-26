using UnityEngine;
using System.Collections;

public class HelicopterMove : MonoBehaviour {
    private Rigidbody2D rb;
    public float speed;
    public Transform monster;
    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector3.up * speed;

    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector2(monster.transform.position.x,transform.position.y);
	}
}
