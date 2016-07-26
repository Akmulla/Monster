using UnityEngine;
using System.Collections;

public class AimMove : MonoBehaviour
{
    public float speed;
    Transform controller;
    Vector2 move;
    public bool hold;
    private Pool pool;
    public float aimTime;
    // Use this for initialization
    void Start ()
    {
        hold = false;
        controller = GameObject.Find("Controller").GetComponent<Transform>();
        pool = GameObject.Find("PoolManager").GetComponent<PoolManager>().GetPool("dangerZone");
    }

    // Update is called once per frame
    void Update()
    {
        if (!hold)
        {
            move = controller.position - transform.position;
            transform.Translate(move.normalized * speed * Time.deltaTime);

            if (move.magnitude<0.5f)
            {
                hold = true;
                StartCoroutine(StartAim());
            }
        }
    }

    IEnumerator StartAim()
    {
        yield return new WaitForSeconds(aimTime);
        hold = false;
        pool.Activate(transform.position, Quaternion.identity);
    }
}
