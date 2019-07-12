using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(add());
        Debug.Log(subtract());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int add()
    {
        int result = 6 + 6;
        return result;
    }

    int subtract()
    {
        int result = 9 - 6;
        return result;
    }
}
