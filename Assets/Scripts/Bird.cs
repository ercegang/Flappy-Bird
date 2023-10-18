using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bird : MonoBehaviour
{
    public float jumpSpeed = 5;
    Rigidbody2D rb;
    public int score;
    public TMP_Text scoreText;
    public float speed;
    public GameObject endScreen;
    public GameObject yellowBird;
    public GameObject redBird;
    public GameObject blueBird;
    public GameObject flashBang;

    private void Start()



    {
        rb = GetComponent<Rigidbody2D>();
        ChooseSkin();
    }
    public void ChooseSkin()
    {

        var num = Random.Range(0f, 1f);
        if (num < 0.33f)
        {
            yellowBird.SetActive(true);
        }
        else if (num < 0.66f)
        {
            redBird.SetActive(true);
        }
        else
        {
            blueBird.SetActive(true);
        }
        
    }

    



    void Update()
    {
        if(Input.GetMouseButton(0) && speed > 0)
        {
           rb.velocity = Vector2.up * jumpSpeed; 
        }

        transform.eulerAngles = new Vector3(0, 0, rb.velocity.y * 7f);

        Pipe.speed = speed;
    }





    void OnCollisionEnter2D(Collision2D other)
    {
        Die();
    }

    

    public void Die()
    {
        speed = 0;
        Invoke("ShowMenu",1f);
        PlayerPrefs.SetInt("score", score);
        flashBang.SetActive(true);
    }

    void ShowMenu()
    {
        scoreText.text = "";
        endScreen.SetActive(true);
        print("end screen");


    }





    public void OnTriggerEnter2D(Collider2D other)
    {
        score++;

        scoreText.text = score.ToString();
        
    }
    
}
