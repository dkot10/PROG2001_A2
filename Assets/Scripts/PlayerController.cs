using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public float value;
    public Vector3 sizeChange;

    //move the player right
    public void MoveRight()
    {
        value = value + 0.01f;
        player.transform.position = new Vector3(value, -0.091f, -9.337f);
    }

    //move the player left
    public void MoveLeft()
    {
        value = value - 0.01f;
        player.transform.position = new Vector3(value, -0.091f, -9.337f);
    }

    //rotate the player left
    public void RotateLeft()
    {
        player.transform.Rotate(0f, 20f, 0f);
    }

    //reset the player to its original position
    public void ResetPlayer()
    {
        player.transform.position = new Vector3(-0.091f, -0.091f, -9.337f);
        player.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
    }

    //expand the player size
    public void Grow()
    {
        player.transform.localScale = player.transform.localScale + sizeChange;
    }
}
