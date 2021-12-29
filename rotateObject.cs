using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class rotateObject : MonoBehaviour
{
    Vector2 lastPosTap;
    float rotationSPD = 2.5f;
    public bool onSelect;
    public UnityEvent onStartDefault;
    // Start is called before the first frame update
    void Start()
    {
        onStartDefault.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastPosTap = (Input.mousePosition);
        }
        else if (Input.GetMouseButton(0) && onSelect)
        {
            var rotX = ((Input.mousePosition).x - lastPosTap.x) * rotationSPD;
            var rotY = ((Input.mousePosition).y - lastPosTap.y) * rotationSPD;
            transform.Rotate(Vector3.up, -rotX, Space.World);
            transform.Rotate(Vector3.left, -rotY, Space.World);

            lastPosTap = Input.mousePosition;
        }
    }

    public void OnSelect()
    {
        onSelect = true;
    }

    public void UnSelect()
    {
        onSelect = false;
    }
}
