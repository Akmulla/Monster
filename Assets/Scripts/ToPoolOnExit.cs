using UnityEngine;
using System.Collections;

public class ToPoolOnExit : MonoBehaviour 
{
	public string poolName;
	Pool pool;

	// Use this for initialization
	void Start () 
	{
		pool = GameObject.Find (poolName).GetComponent<Pool> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.y < Edges.botEdge-2.0f)
			pool.Deactivate (gameObject);
	}
}
