using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Enemy;
    public float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;
        if (timer > 2)
        {
            timer = 0;
            Make_Enemy();
        }
          
    }

    public void Make_Enemy()
    {
        Instantiate (Enemy,new Vector3(Random.Range(-9,+9),6,0),Quaternion.identity);
    }
}
