using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crusher : MonoBehaviour
{
    public float speed;
    public int maximumXPosition;
    public int minimumXPosition;
    private void FixedUpdate()
    {
        if (transform.position.x <= minimumXPosition || transform.position.x >= maximumXPosition)
        {
            speed *= -1;
        }
        float newXposition = transform.position.x + speed * Time.fixedDeltaTime;
        float newYposition = transform.position.y;
        Vector2 newPosition = new Vector2 (newXposition, newYposition);
        transform.position = newPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
