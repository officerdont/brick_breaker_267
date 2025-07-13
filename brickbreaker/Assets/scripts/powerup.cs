using UnityEngine;

public class powerup : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
 // choice between 1 and 3, then set the powerup to that number
    // 1 = double points, 2 = extra life, 3 = extra ball
    private int powerupChoice;
    private void Start()
    {
        powerupChoice = Random.Range(1, 4);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the player    
        if (collision.gameObject.CompareTag("Player"))
        {
            
            // Apply the powerup based on the choice
            switch (powerupChoice)
            {
                case 1:
                    Object.FindFirstObjectByType<NewBehaviourScript>().doublepoints();
                    Destroy(this.gameObject);
                    break;
                case 2:
                    Object.FindFirstObjectByType<NewBehaviourScript>().extraLife();
                    Destroy(this.gameObject);
                    break;
                case 3:
                    Object.FindFirstObjectByType<ballmovement>().speedup();
                    Destroy(this.gameObject);
                    break;
            }

            Destroy(this.gameObject);

        }
       
    }
}
