using UnityEngine;
using System.Collections;

public class OrbitalStrike : MonoBehaviour
{
    public GameObject strike;
    public int count;
	// Use this for initialization
	void Start ()
    {
	    for (int i=0;i < count;i++)
        {
            Instantiate(strike, new Vector2(Random.Range(Edges.leftEdge, Edges.rightEdge), Random.Range(Edges.botEdge, Edges.topEdge)), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
