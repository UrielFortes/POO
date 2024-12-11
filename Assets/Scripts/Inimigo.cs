using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public float velocidade;
    public float forcaPulo;
    public Rigidbody rb;
    public bool isChao;
    public GameObject inimigo;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
        Pular();
        MudarCorDoInimigo();
    }
    public void Mover()
    {
        float x = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;

        transform.Translate(x, 0, z);
    }
    public void Pular()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isChao == true)
        {
            rb.AddForce(transform.up * forcaPulo);
            isChao = false;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "chao")
        {
            isChao = true;
        }
        else
        {
            isChao = false;
        }
    }
    public void MudarCorDoInimigo()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Color randonColor;

            randonColor = new Color(Random.Range(0f, 1f),Random.Range(0f, 1f),Random.Range(0f, 1f));
            inimigo.GetComponent<Renderer>().material.color = randonColor;


        }
    }
}
