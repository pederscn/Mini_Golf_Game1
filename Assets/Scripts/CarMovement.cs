using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveDistance = 10f; // Distance the car will move back and forth
    public float moveSpeed = 5f;     // Speed at which the car moves

    private Vector3 startPos;
    private Vector3 endPos;
    private bool movingToEnd = true;

    private void Start()
    {
        startPos = transform.position;
        endPos = startPos + Vector3.right * moveDistance;
    }

    private void Update()
    {
        if (movingToEnd)
        {
            MoveCar(endPos);
        }
        else
        {
            MoveCar(startPos);
        }

        // Check if the car has reached its destination
        if (Vector3.Distance(transform.position, endPos) < 0.1f)
        {
            movingToEnd = false;
        }
        else if (Vector3.Distance(transform.position, startPos) < 0.1f)
        {
            movingToEnd = true;
        }
    }

    private void MoveCar(Vector3 targetPos)
    {
        // Move the car towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
    }
}
