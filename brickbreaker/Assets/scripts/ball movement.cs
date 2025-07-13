using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovement : MonoBehaviour
{
   public  Rigidbody2D rd { get; private set; }
    public float speed = 500f;

    private void Awake()
    {
        this.rd = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        // Start the ball movement after a short delay
        
        Invoke("startmovement", 1f);
       
    }
    private void startmovement()
    {
        

        Vector2 force = Vector2.zero;
        force.y = -1f;

        this.rd.AddForce(force.normalized * this.speed);
         
    }

    public void speedup()
    {
       this.rd.AddForce(this.rd.linearVelocity.normalized * 100f);

    }
}

