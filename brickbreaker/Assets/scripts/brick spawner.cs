using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickspawner : MonoBehaviour
{
   // choice between 4 type of bricks then spawn prefab
   public GameObject regbrick;
   public GameObject hardbrick;
   public GameObject pointmultibrick;
   public GameObject powerbrick;

    void Start()
    {
        // spawn brick
        int randomNumber = Random.Range(0, 4);
        switch (randomNumber)
        {
            case 0:
                // spawn regular brick
                Instantiate(regbrick, transform.position, Quaternion.identity);


                break;
            case 1:
                // spawn hard brick
                Instantiate(hardbrick, transform.position, Quaternion.identity);


                break;
            case 2:
                // spawn point multiplier brick
                Instantiate(pointmultibrick, transform.position, Quaternion.identity);


                break;
            case 3:
                // spawn power brick
                Instantiate(powerbrick, transform.position, Quaternion.identity);


                break;
        }


    }
   


}
