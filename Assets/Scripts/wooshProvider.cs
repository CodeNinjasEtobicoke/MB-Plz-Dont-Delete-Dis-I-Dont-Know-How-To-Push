using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using
public class wooshProvider : MonoBehaviour
{
    public int enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }

    // Update is called once per frame
 private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
