using UnityEngine;
using System.Collections;

public class BonusReaction : MonoBehaviour
{
    private Pool pool;

    void Start()
    {
        pool = GetComponent<EnemyInfo>().pool;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name=="Controller")
        {
            pool.Deactivate(gameObject);
        }
    }
}
