using UnityEngine;
using System.Collections;

public class Charger : MonoBehaviour
{
    public float speed;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
