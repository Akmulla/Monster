using UnityEngine;
using System.Collections;

public class ControllerVerticalMove : MonoBehaviour
{

    //public float speed;
    public BossVerticalMove bossVerticalMove;
    private ControllerReaction controllerReaction;

    void Start()
    {
        controllerReaction = GetComponent<ControllerReaction>();
    }

    void Update()
    {
        if (!controllerReaction.stunned)
        {
            transform.Translate(Vector2.up * bossVerticalMove.speed * Time.deltaTime, Space.World);
        }
        
    }
}
