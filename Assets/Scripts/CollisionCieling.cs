using System.Collections;
using UnityEngine;

//Repetative Code pretty sure theres a way to make it work better
public class CollisionCieling : MonoBehaviour
{
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        onCollsiion(collision);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        onCollsiion(collision);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        onCollsiion(collision);
    }

    void onCollsiion(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pipe")
        {
            Physics2D.IgnoreCollision(collision.collider, this.GetComponent<Collider2D>());
        }
    }

}
