using UnityEngine;

public class Hazard : MonoBehaviour
{
    Rigidbody2D myRigidbody;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            DamageHazard();
        }
    }

    void DamageHazard()
    {
        if(this.CompareTag("Water_Hazard"))
        {
            Debug.Log("Player Drowned");
        }
        else if(this.CompareTag("Spike_Fall_Trap"))
        {
            Debug.Log("Player Impaled");
        }
    }
}
