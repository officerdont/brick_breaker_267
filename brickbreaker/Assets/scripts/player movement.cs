using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody2D rd { get; private set; }
    // player direction
    public Vector2 direction { get; private set; }
    // player speed
    public float speed = 20f;
   private float horizontalInput;
    public float maxbounceangle = 70; // Maximum bounce angle in degrees

    private void Awake()
    {
        this.rd = GetComponent<Rigidbody2D>();

    }
    private void Update()
    {
        movelateral();

    }
    private void movelateral()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        direction = new Vector2(horizontalInput, 0).normalized;
        if (direction != Vector2.zero)
        {
            this.rd.linearVelocity = new Vector2(direction.x * speed, rd.linearVelocity.y);
        }



    }
    private void FixedUpdate()
    {
        if (direction != Vector2.zero)
        {
            this.rd.AddForce(this.direction * this.speed);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ballmovement ball = collision.gameObject.GetComponent<ballmovement>();
        if (ball != null)
        {
            Vector3 paddleposition = this.transform.position;
            Vector2 contactpoint = collision.GetContact(0).point;

            float offset = paddleposition.x - contactpoint.x;
            float width = collision.otherCollider.bounds.size.x / 2;

            float currentangle  = Vector2.SignedAngle(Vector2.up, ball.rd.linearVelocity);
            float bounceangle = (offset / width) * this.maxbounceangle; 

            float newangle = Mathf.Clamp(currentangle + bounceangle, -this.maxbounceangle,this.maxbounceangle);

            Quaternion rotation = Quaternion.AngleAxis(newangle, Vector3.forward);
            ball.rd.linearVelocity = rotation * Vector2.up * ball.rd.linearVelocity.magnitude;

        }
    }
}
