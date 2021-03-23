using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 5;

    // Update is called once per frame
    void Update()
    {
        float hori = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float vert = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(hori, 0, vert);
    }
}
