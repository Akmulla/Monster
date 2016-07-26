using UnityEngine;

public class FoodReaction : MonoBehaviour
{
    private Pool pool;

    void Start()
    {
        pool = GetComponent<EnemyInfo>().pool;
        //Debug.Log(pool);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Boss")
        {
            pool.Deactivate(gameObject);
        }
    }
}
