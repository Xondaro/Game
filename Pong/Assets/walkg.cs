using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkg : MonoBehaviour
{

    private Rigidbody2D Rb;
    void Start()
    {
        Rb = this.GetComponent<Rigidbody2D>();
        StartCoroutine("wait");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator wait()
    {
        yield return new WaitForSeconds(3f);
        wlk();

    }
    private void wlk()
    {
        Rb.velocity = new Vector2(-2.5f, 0);
        if (Rb.position.x <= -2)
        {
            Rb.velocity = new Vector2(0, 0);
        }
    }
}
