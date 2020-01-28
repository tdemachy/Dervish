using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
		Vector3 move = new Vector3();

		if (Input.GetKey(KeyCode.UpArrow))

			move.z += 0.5f;

		if (Input.GetKey(KeyCode.DownArrow))

			move.z -= 0.5f;

		if (Input.GetKey(KeyCode.LeftArrow))

			move.x -= 0.5f;

		if (Input.GetKey(KeyCode.RightArrow))

			move.x += 0.5f;

		transform.position += move;
	}
}
