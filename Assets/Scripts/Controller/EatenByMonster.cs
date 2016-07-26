using UnityEngine;
using System.Collections;

public class EatenByMonster : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (transform.position.y<Edges.botEdge)
        {
            //Debug.Log("sdfg");
            Application.LoadLevel(0);
        }
	}
}
