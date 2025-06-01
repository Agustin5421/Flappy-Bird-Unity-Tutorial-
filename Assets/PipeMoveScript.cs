using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 4;
    public float deadZone = -25;

    void Update()
    {   
        transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
        
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
