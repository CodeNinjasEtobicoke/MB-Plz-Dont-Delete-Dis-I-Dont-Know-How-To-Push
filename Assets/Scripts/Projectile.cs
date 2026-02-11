using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
{
    public Throwable direction;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction.offset * Time.deltaTime * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            DestroyThrowable();
        }
    }



private void DestroyThrowable()
    {
        Destroy(gameObject);
        Invoke("Reload", 3);
    }
}
