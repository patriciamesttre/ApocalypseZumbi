using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidade = 100f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.forward * velocidade * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider objetoColidido)
    {
        if (objetoColidido.tag == "Inimigo")
        {
            Destroy(objetoColidido.gameObject);
        }

    }
}

