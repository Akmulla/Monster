using UnityEngine;
using System.Collections;

public class DestroyOnExit : MonoBehaviour
{
    private Pool pool;

    void Start()
    {
        pool = GetComponent<EnemyInfo>().pool;
    }

    void Update()
    {
        if ((transform.position.x<Edges.leftEdge)||(transform.position.x>Edges.rightEdge)
            //||(transform.position.y>Edges.topEdge)
            ||(transform.position.y<Edges.botEdge))
        {
            pool.Deactivate(gameObject);
        }
    }
}
