using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;
    public Vector3 offset;
    public int throwableCounter;

    // Update is called once per frame
    void Update()
    {
    
        if (Input.GetButtonDown("Pick up"))
        {
            if (throwableCounter > 0)
            {
                throwableCounter -= 1;

                offset = transform.localScale.x * new Vector3(1, 0, 0);

                Vector3 throwablePosition = transform.position + offset;

                Instantiate(objectThrown, throwablePosition, transform.rotation);

            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collectable")
        {
            throwableCounter += 1;
            Destroy(collision.gameObject);

        }

    }


}