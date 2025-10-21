using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI RestartButton;
    public TextMeshProUGUI ScoreText;
    public SceneManager sceneManager;
    protected float speed = 20;
     private float turnspeed = 25;
     private float horizontalInput;
    private float forwardInput;
    private int score = 0;
    // Start is called before the first frame update
    void Start()    
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // we turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalInput);
        if (forwardInput != 0 ) RestartButton.gameObject.SetActive(false);
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void updateScore(int score)
    {
        this.score += score;
        ScoreText.text = "Score: " + this.score;
    }
        
}
