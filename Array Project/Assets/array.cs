using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{
    int counter;
    GameObject[] arr;
    public GameObject boss;
    System.Random rand;
    int x;
    int y;
    int j;
    // Start is called before the first frame update
    void Start()
    {
        arr = new GameObject[10];
        for (int i = 0; i < 10; i++)
        {
            rand = new System.Random();
            x = rand.Next(-8, 8);
            y = rand.Next(-5, 5);
            Vector2 vec = new Vector2(x, y);
            arr[i] = Instantiate(boss, vec, Quaternion.identity);
        }

      
    }

    // Update is called once per frame
    void Update()
    {
        counter++;

        if(counter == 60)
        {
           
            arr[j].SetActive(false);
            counter = 0;
            j++;
        }
    }
}
