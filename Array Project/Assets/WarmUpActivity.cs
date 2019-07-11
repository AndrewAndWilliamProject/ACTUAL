using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WarmUpActivity : MonoBehaviour
{
    int k = 0;
    // Start is called before the first frame update
    void Start()
    {
        int[] arr = new int[21];
        for (int i = 0; i <= 40; i++)
        {

            if (i % 2 == 0)
            {
                arr[i/2] = i;
            }
        }

        byFour(40);
    }

    void byFour(int x)
    {
        int[] array = new int[x];
        array[0] = 0;
        for(int i = 0; i < x; i++)
        {
            if(i % 4 == 0)
            {
                array[i / 4] = i;
            }
            foreach (int j in array)
            {
                Debug.Log(j);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
