using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monoBehaviour : MonoBehaviour
{
    bool move = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (move == true)
        {
            this.transform.Translate(new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.transform.position = new Vector3(1f, 1f, 1f);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (move)
            {
                move = false;
            }
            else
            {
                move = true;
            }
        }
    }
}
