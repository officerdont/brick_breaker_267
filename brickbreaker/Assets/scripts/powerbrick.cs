using UnityEngine;

public class powerbrick : MonoBehaviour
{
    //spawn prefab of powerup at the position of the brick
    public GameObject powerupPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // get a random number between 1 and 3 , then set the powerup to that number



    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the player
        if (collision.gameObject.CompareTag("Ball"))
        {
            Object.FindFirstObjectByType<NewBehaviourScript>().addpoints(30);
            Object.FindFirstObjectByType<NewBehaviourScript>().bricksleft();

            Destroy(this.gameObject);
            Instantiate(powerupPrefab, transform.position, Quaternion.identity);
            ;
        }
        


    }
}
