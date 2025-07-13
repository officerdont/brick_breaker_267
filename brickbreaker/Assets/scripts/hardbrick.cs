using UnityEngine;

public class Hardbrick : MonoBehaviour
{
    int numofhits = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the player
        if (collision.gameObject.CompareTag("Ball"))
        {
            numofhits++;
            if (numofhits >= 2)
            {


                // Replace deprecated FindObjectOfType with FindFirstObjectByType
                Object.FindFirstObjectByType<NewBehaviourScript>().addpoints(20);
                Object.FindFirstObjectByType<NewBehaviourScript>().bricksleft();
                Destroy(this.gameObject);
            }
            else
            {
                Debug.Log("Hardbrick hit, remaining hits: " + (2 - numofhits));
            }
        }
       
       
    }
}
