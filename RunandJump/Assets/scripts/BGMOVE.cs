using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMOVE : MonoBehaviour
{
    public Vector3 startPos;

    private float repeatWidth;

    public float speed = 20;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        {
            playerControllerScript =
                GameObject.Find("Player").GetComponent<PlayerController>();
        }
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate((Vector3.left * Time.deltaTime * speed));
        }
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
        {
           // transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
