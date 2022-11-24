using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Start()
    {
        //qualitysettings.vsynccount = 0;
        //application.targetframerate = 10;
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 position = rigidbody2d.position;
        position.x = position.x + 100.0f * horizontal * Time.deltaTime;
        position.y = position.y + 100.0f * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }
}