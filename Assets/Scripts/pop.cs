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
           toSpawn = Instantiate(toSpawn, new Vector3(Random.Range(-20f, 20f), 2f, Random.Range(-20f, 20f)), Quaternion.identity, this.transform);
    }
}
