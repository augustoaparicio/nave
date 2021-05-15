using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpaceShip : MonoBehaviour
{
    int delay = 0;
    GameObject a;
    public GameObject bullet;
    Rigidbody2D rb;
    public float speed;
    int Health = 3;
    public Text Victoria;
    public Text Derrota;
    float tiempo;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        a = transform.Find("a").gameObject;
    }

    void Start()
    {

    }


    void Update()
    {
        rb.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0));
        rb.AddForce(new Vector2(0, Input.GetAxis("Vertical") * speed));

        if (Input.GetKey(KeyCode.Space) && delay > 10)
            Shoot();

        delay++;

        tiempo = Time.deltaTime;
        if (tiempo == 30)
        {
            SceneManager.LoadScene("Fiambre");
        }

    }

    public void Damage()
    {
        Health--;
        if (Health == 0)
            SceneManager.LoadScene("Matematicas");
    }

    void Shoot(){
        Instantiate(bullet, a.transform.position, Quaternion.identity);
    }
    

    

}
