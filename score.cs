using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    Rigidbody rb = new Rigidbody();
   int count = 0;
   public Text countText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        countText.text = "Очки " + count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");
        
        Vector3 move = new Vector3(hor, 0.0f, ver);

        rb.AddForce(move);
    }

private void OnTriggerEnter(Collider other)
{
    if(other.gameObject.CompareTag("PU"))
    {
        other.gameObject.SetActive(false);
        count++; // count = count + 1;
        countText.text = "Очки " + count.ToString();
    }
}
}

