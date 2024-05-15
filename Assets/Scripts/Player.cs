using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Shooting();
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(10*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(10*Time.deltaTime, 0, 0);
        }
    }
    public void Shooting()
    { 
       GameObject B = Instantiate(Bullet , GameObject.Find("Position").transform.position , Quaternion.identity);
       B.GetComponent<Rigidbody2D>().AddForce(Vector2.up*1000);
       Destroy(B, 2f);
    }
}
