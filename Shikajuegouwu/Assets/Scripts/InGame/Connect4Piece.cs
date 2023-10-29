using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connect4Piece : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Connect4Piece>() == null)
        {
            int x = int.Parse(gameObject.name.Split(',')[0].Split(' ')[1]);
            int y = int.Parse(gameObject.name.Split(',')[1]);
            OnPiecePlaced(x, y);
        }
    }
    public void OnPiecePlaced(int x, int y)
    {
        // Check for winner
    }
}
