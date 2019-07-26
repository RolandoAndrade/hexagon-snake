using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board
{
    private List<SpriteRenderer> board;

    private Snake snake;

    private Color color;

	public Board(SpriteRenderer[] sr,Snake snake)
    {
        board = new List<SpriteRenderer>();
        foreach (SpriteRenderer s in sr)
        {
            int t = Utils.IntParseFast(s.gameObject.name);
            if (t == -1)
                board.Add(s);
        }
        this.snake = snake;
        color = board[0].color;
    }
    private void DrawSnake()
    {
        foreach(int index in snake.GetPositions())
        {
            board[index].color = Color.white;
        }
    }

    public void Clear()
    {
        foreach (SpriteRenderer sr in board)
            sr.color = color;
    }
    public void Update()
    {
        Clear();
        snake.Move();
        DrawSnake();
        
    }
}
