using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pop : MonoBehaviour
{

    public GameObject toSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
           toSpawn = Instantiate(toSpawn, new Vector3(Random.Range(-30f, 30f), Random.Range(0f, 20f), Random.Range(-30f, 30f)), Quaternion.identity, this.transform);
    }
}
