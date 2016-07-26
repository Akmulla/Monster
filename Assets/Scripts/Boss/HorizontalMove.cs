using UnityEngine;
using System.Collections;

public class HorizontalMove : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }
	
	void Update ()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Boundary"))
        {
            speed *= -1;
        }
    }

    
}
