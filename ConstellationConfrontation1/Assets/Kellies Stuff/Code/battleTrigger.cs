using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battleTrigger : MonoBehaviour
{
    public GameObject Box;
    public GameObject that;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("b"))
        {
            Box.SetActive(true);
            that.SetActive(false);
            Destroy(other.gameObject);
        }
    }

}
