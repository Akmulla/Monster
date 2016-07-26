using UnityEngine;

public class EnemyInfo : MonoBehaviour
{
    public string enemyName;
    public Pool pool;

    void Awake()
    {
        pool = GameObject.Find("PoolManager").GetComponent<PoolManager>().GetPool(enemyName);
    }

}
