using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EC : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (collision.gameObject.CompareTag("ThrowingObject"))
        {
            Debug.Log("shuriken hit enemy");
            Invoke("Reload", 3);
        }
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);

        if (collision.gameObject.CompareTag("ThrowingObject"))
        {
            Debug.Log("shuriken hit enemy");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene(1);
        }
    }
}



    


