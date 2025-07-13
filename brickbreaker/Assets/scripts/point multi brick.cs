using UnityEngine;

public class pointmultibrick : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the player
        if (collision.gameObject.CompareTag("Ball"))
        {
            Object.FindFirstObjectByType<NewBehaviourScript>().doublepoints();
            Object.FindFirstObjectByType<NewBehaviourScript>().bricksleft();
            Destroy(this.gameObject);
            ;
        }
      
    }
}
