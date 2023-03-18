using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PheromoneHandler : MonoBehaviour
{

    [SerializeField]
    private int duration = 600;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (duration == 0){
            Destroy(this);
        }
        duration-=1;
    }
}
