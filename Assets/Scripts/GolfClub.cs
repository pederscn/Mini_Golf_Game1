using UnityEngine;

public class GolfClub : MonoBehaviour
{
    public float hitForce = 1000f; // Adjust this value to control the force applied to the golf ball.

    // Called when the golf club hits the golf ball (you can call this function from other scripts or events)
    public void HitBall()
    {
        // Find the golf ball in the scene
        GameObject golfBall = GameObject.Find("GolfBall");

        // Check if the golf ball exists in the scene
        if (golfBall != null)
        {
            // Get the golf ball's Rigidbody component
            Rigidbody ballRigidbody = golfBall.GetComponent<Rigidbody>();

            // Apply force to the golf ball in the forward direction of the club
            ballRigidbody.AddForce(transform.forward * hitForce);
        }
    }
}
