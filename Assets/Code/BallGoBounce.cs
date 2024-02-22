using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    public float speed = 5f;
    public float distance = 5f;

    private Vector3 startPosition;
    private Vector3 movementDirection = Vector3.right; // Move it on X axis cuz I constructed the walls already and am too lazy to flip em to Z
    //Z axis? More like Snore axis cuz -_- zzzzzzzzzzzzzzzzzzzzzz

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the movement from the start position
        Vector3 movement = transform.position - startPosition;

        // Calculate the dot product between movement and its direction
        float dot = Vector3.Dot(movement, movementDirection);

        // If the dot product is greater than the distance, reverse the direction AKA Ball go bounce :D
        if (dot > distance || dot < -distance)
        {
            movementDirection = -movementDirection;
        }

        // Calculate the movement vector using the movement direction and speed
        Vector3 movementInAction = movementDirection * speed * Time.deltaTime;

        // Do the move :D
        transform.position += movementInAction;
    }
}
