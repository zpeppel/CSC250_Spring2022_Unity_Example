using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    private int count;
    private int floorCount;
    private Rigidbody rb;
    public float speed = 20f;
    private Quaternion vectorRotation;
    private int rotation;
    





    // Start is called before the first frame update
    void Start() //like a constructor
    {
        count = 0;
        floorCount = 0;
        
        


        rb = this.gameObject.GetComponent<Rigidbody>();
    }


    
    void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag.Equals("Player"))
        {
            CORE.display();
            count++;
            if(count == 3)
            {
                //this.gameObject.SendMessage("DoSomething");
                Destroy(this.gameObject);
            }
        }
        else if(collision.gameObject.tag.Equals("floor"))
        {
            for (int i = 0; i < 2; i++)
            {
                int x = Random.Range(0, 360);
                int z = Random.Range(0, 360);
                Vector3 direction = new Vector3(x / 200, 0, z / 200);
                rb.velocity = direction * speed;
                print("hi");
            }
            
            
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
