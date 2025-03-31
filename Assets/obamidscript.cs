using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class obamidscript : MonoBehaviour
{
    public Rigidbody2D Rigidbody;
    public float jumpstrength;
    public logicscript logic;
    public bool birdIsAvlive = true;

    audiomanager audiomanager;

        
      // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
        audiomanager = GameObject.FindGameObjectWithTag("audio").GetComponent<audiomanager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAvlive)
        {
            Rigidbody.linearVelocity = Vector2.up * jumpstrength;

            audiomanager.PlaySFX(audiomanager.jump);
        }
    }
        private void OnCollisionEnter2D(Collision2D collision)
    {
        audiomanager.PlaySFX(audiomanager.hit);
        logic.gameOver();
        birdIsAvlive = false;
    }
    


   
}
