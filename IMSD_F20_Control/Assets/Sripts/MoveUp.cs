using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public Transform myTransform;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {

        myTransform.position = new Vector3(0, -5, 0);

    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;

    }
}
