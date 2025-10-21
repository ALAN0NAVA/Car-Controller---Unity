using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private PlayerController PC;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PC = GameObject.Find("Car").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -4f)
        {
            Destroy(gameObject);
            PC.updateScore(100);
        }
    }
}
