using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Sul.SOperations;
public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        bool[] i = {true, true, false};
        bool result = all(i);

        print(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
