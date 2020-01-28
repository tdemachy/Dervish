using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{
    public float m_translationSpeed = 0.1f;
    public float m_rotationSpeed = 1.0f;


    private Camera _camera;
    private Vector3 _referencePosition;

    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<Camera>();
        _referencePosition = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 deltaPos = Input.mousePosition - _referencePosition;

        if (Input.GetMouseButton(0))
        {      
            float angle = m_rotationSpeed * 360.0f * deltaPos.x / Screen.width;
            transform.Rotate(_camera.transform.up, angle);

            angle =  -m_rotationSpeed *  360.0f * deltaPos.y / Screen.height;
            transform.Rotate(_camera.transform.right, angle);
        }

        if (Input.GetMouseButton(1))
        {
            Vector3 translation = new Vector3(deltaPos.x * m_translationSpeed, 0.0f, deltaPos.y * m_translationSpeed);
            transform.position += translation;
        }

        _referencePosition = Input.mousePosition;
    }
}
