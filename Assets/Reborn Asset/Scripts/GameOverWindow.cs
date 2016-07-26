using UnityEngine;
using System.Collections;

public class GameOverWindow : MonoBehaviour
{
    public Sprite win;
    public Sprite loss;
	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        Touch myTouch;
        if (Input.touchCount > 0)
        {
            myTouch = Input.GetTouch(0);
            if (myTouch.phase==TouchPhase.Began)
            {
                Application.LoadLevel(0);
            }
        }

    }


}
