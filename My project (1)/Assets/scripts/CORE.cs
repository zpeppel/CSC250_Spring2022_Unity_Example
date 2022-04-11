using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CORE : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    //private Rigidbody rb;
    public float speed = 20f;

    private static List<GameObject> theRooms = new List<GameObject>();

    public static void addRoomGO(GameObject go)
    {
        CORE.theRooms.Add(go);
        print("Added Room");
    }

    public static void display()
    {
        print("Player and enemy colided");
    }
    void OnCollisionEnter(Collision collision)
    {
        
    }

    

    

        // Start is called before the first frame update
        void Start()
        {
        for (int i = 0; i < 20; i++)
        {
            Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
            //StartCoroutine(waiter());
            
        }


    }
    IEnumerator waiter()
{
    //Wait for 5 seconds
    yield return new WaitForSeconds(5);

    
}
// Update is called once per frame
void Update()
    {
        
    }
}
