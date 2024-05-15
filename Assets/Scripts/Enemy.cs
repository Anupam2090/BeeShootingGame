using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Bullet")
        {
            GameObject.Find("Manager").GetComponent<Manager>().Score += 1; // Go and find "Manager" and increases score by 1
            GameObject.Find("Manager").GetComponent<Manager>().Save();
            
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
