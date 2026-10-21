using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2f;

    Rigidbody2D enemyRididbody;
    void Start()
    {
        enemyRididbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyRididbody.linearVelocity = new Vector2(
            moveSpeed,
            enemyRididbody.linearVelocity.y);
    }
    void OnTriggerExit2D(Collider2D other)
    {
        moveSpeed = -moveSpeed;

        transform.localScale = new Vector2(
            -transform.localScale.x,
            transform.localScale.y);
    }
}
