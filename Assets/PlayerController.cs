using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float movespeed = 1f;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float hrMove = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        float vrMove = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;

        rb.transform.Translate(new Vector2(hrMove, vrMove));
    }
}
