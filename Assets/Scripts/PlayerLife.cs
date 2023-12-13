using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private SpriteRenderer sprite;

    private CircleCollider2D coll;

    private BoxCollider2D collide;

    public AudioSource dieSound;

    // Start is called before the first frame update
    public void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        coll = GetComponent<CircleCollider2D>();
        collide = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DeathBlock"))
        {
            Die(); //Calls Die() method
        }
    }

    private void Die()
    {
        sprite.enabled = false; //Disables Sprite Renderer for Player, so doesn't show him when hit in game.
        GetComponent<PlayerMovement>().enabled = false; //Disables PlayerMovement Script, stopping movement of the player
        coll.enabled = false; //Disables Collider
        collide.enabled = false; //Disables Box Collider (Level05 Only)
        dieSound.Play(); //Plays dieSound
        Invoke(nameof(ReloadLevel), 1.5f); //Calls ReloadLevel() method after 1.5 second delay

    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //Gets the current scene from build settings in Unity and reloads it.
    }
}
