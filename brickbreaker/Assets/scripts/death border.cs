using UnityEngine;

public class deathborder : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Ball"))
        {
            Object.FindFirstObjectByType<NewBehaviourScript>().loseLife();

        }
        else
        {
            // If the collision is not with the ball, destroy the object
            Destroy(collision.gameObject);

        }

    }
}
