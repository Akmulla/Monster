using UnityEngine;
using System.Collections;

public class HelicopterLeave : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (transform.position.y>Edges.topEdge)
        {
            GameController.GameOver();            
        }
	}
}
