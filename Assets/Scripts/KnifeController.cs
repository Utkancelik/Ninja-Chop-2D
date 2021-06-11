using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeController : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool isPressed;
    public float releaseTime = 0.15f;
    public bool hicTikladiMi = true;

    private void Update()
    {
        if (isPressed)
        {
            Vector3 Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            rb.position = Pos;
        }
    }
    private void OnMouseDown()
    {
        if (hicTikladiMi)
        {
            rb.isKinematic = true;
            isPressed = true;
        }
        



    }
    private void OnMouseUp()
    {

        rb.isKinematic = false;
        isPressed = false;
        StartCoroutine(Release());
        hicTikladiMi = false;
        rb.constraints = RigidbodyConstraints2D.None;

    }

    IEnumerator Release()
    {
        yield return new WaitForSeconds(releaseTime);

        GetComponent<SpringJoint2D>().enabled = false;
    }
}
