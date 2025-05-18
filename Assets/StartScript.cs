using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Start");
    }

    int v = 0;
    // Update is called once per frame
    void Update()
    {
        v = v + 1;
        Debug.Log(v + " Update");
    }
}
