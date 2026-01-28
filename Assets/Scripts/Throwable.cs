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
    
        if (Input.GetButtonDown("Fire1"))
        {
            throwableCounter -= 1;

            offset = new Vector3(1, 0, 0);

            Vector3 throwablePosition = transform.position + offset;

            Instantiate(objectThrown, throwablePosition, transform.rotation);

            offset = transform.localScale.x * new Vector3(1, 0, 0);

        }

    }
    
    private void OnCollisionEnter2D() {
        if (gameObject.CompareTag("Collectable"))
        {
            throwableCounter += 1;
            Destroy(gameObject);
        }
    }
   
}
