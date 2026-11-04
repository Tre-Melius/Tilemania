using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2f;

    Rigidbody2D enemyRididbody;
    BoxCollider2D groundcollider;
    void Start()
    {
        enemyRididbody = GetComponent<Rigidbody2D>();
        groundcollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyRididbody.linearVelocity = new Vector2(
            moveSpeed,
            enemyRididbody.linearVelocity.y);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy_Turning_Barrier"))
        {
            ChangeDirection();
        }
    }

    void ChangeDirection()
    {
        moveSpeed = -moveSpeed;

            transform.localScale = new Vector2(
                -transform.localScale.x,
                transform.localScale.y);
                Debug.Log("Exit Trigger");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
