using UnityEngine;
using System.Collections;

public class VerticalMove : MonoBehaviour
{
    //public float maxSpeed;
    public float speed;
	
    void Start()
    {
        //speed = maxSpeed;
    }

	void Update ()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime,Space.World);
    }
}
