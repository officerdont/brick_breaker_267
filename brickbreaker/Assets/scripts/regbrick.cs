using UnityEngine;

public class regbrick : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnCollisionEnter2D(Collision2D collision)
    {

        // Check if the collision is with the player
        if (collision.gameObject.CompareTag("Ball"))
        {
            Object.FindFirstObjectByType<NewBehaviourScript>().addpoints(10);
            Object.FindFirstObjectByType<NewBehaviourScript>().bricksleft();
            Destroy(this.gameObject); 
        }
       
    }
}
