using UnityEngine;
using System.Collections;

public class Flip : MonoBehaviour
{
    public bool isFacingRight = true;
    private Rigidbody2D rb;
    // Use this for initialization
    void Start ()
    {
        rb = GetComponentInParent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (rb.velocity.x > 0 && !isFacingRight)
            //отражаем персонажа вправо
            FlipCharacter();
        //обратная ситуация. отражаем персонажа влево
        else if (rb.velocity.x < 0 && isFacingRight)
            FlipCharacter();
    }

    public void FlipCharacter()
    {
        //меняем направление движения персонажа
        isFacingRight = !isFacingRight;
        //получаем размеры персонажа
        Vector3 theScale = transform.localScale;
        //зеркально отражаем персонажа по оси Х
        theScale.x *= -1;
        //задаем новый размер персонажа, равный старому, но зеркально отраженный
        transform.localScale = theScale;
    }
}
