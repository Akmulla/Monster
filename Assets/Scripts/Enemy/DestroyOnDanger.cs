using UnityEngine;
using System.Collections;

public class DestroyOnDanger : MonoBehaviour
{
    private Pool pool;

    void Start()
    {
        pool = GetComponent<EnemyInfo>().pool;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "DangerZone")
        {
            pool.Deactivate(gameObject);
        }
    }
}
