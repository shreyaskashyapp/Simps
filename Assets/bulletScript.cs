using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float life=1;
    void Awake()
    {
        Destroy(gameObject,life);
    }

    // Update is called once per frame
   
}
