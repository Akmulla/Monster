using UnityEngine;
using System.Collections;

public class MonsterAnimationFunctions : MonoBehaviour
{
    public GameObject helicopter;

    void Start()
    {
        helicopter = GameObject.Find("Helicopter");
    }

    public void EatHelicopter()
    {
        Destroy(helicopter);
    }

	public void HelicopterEaten()
    {
        GameController.Win();
    }
}
