using UnityEngine;
using System.Collections;

public class GenerateGround : MonoBehaviour 
{
	public GameObject tile;
	public Sprite[] sprites;
	float botEdge;
	float leftEdge;
	float spriteHeight;
	float spriteWidth;
	Pool pool;

	// Use this for initialization
	void Start () 
	{
		pool = GetComponentInChildren<Pool> ();
		spriteHeight = sprites [0].bounds.size.y * transform.localScale.y;
		spriteWidth = sprites [0].bounds.size.y * transform.localScale.x;
		botEdge = Edges.botEdge;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (botEdge <= Edges.topEdge+spriteHeight)
		{
			Generate ();
		}
	}

	void Generate()
	{
		while (botEdge <= Edges.topEdge+spriteHeight)
		{
			leftEdge = Edges.leftEdge;
			while (leftEdge <= Edges.rightEdge+spriteWidth)
			{
				//GameObject obj = (GameObject)Instantiate (tile, new Vector2 (leftEdge, botEdge), Quaternion.identity);
				GameObject obj=pool.Activate(new Vector2 (leftEdge, botEdge), Quaternion.identity);
				obj.GetComponent<SpriteRenderer> ().sprite = sprites [Random.Range (0, sprites.Length)];
				leftEdge += spriteWidth;
			}
			botEdge += spriteHeight;
		}
	}
}
