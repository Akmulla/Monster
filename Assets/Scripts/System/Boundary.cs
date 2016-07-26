using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour
{
    public Transform top;
    public Transform bot;
    public Transform left;
    public Transform right;
    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        top.transform.position = new Vector2((Edges.rightEdge + Edges.leftEdge) / 2, Edges.topEdge);
        bot.transform.position = new Vector2((Edges.rightEdge + Edges.leftEdge) / 2, Edges.botEdge);
        left.transform.position = new Vector2(Edges.leftEdge, (Edges.topEdge + Edges.botEdge) / 2);
        right.transform.position = new Vector2(Edges.rightEdge, (Edges.topEdge + Edges.botEdge) / 2);
    }
}
