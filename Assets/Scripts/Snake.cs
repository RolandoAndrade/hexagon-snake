using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake
{
    private List<Body> snake;
    public Snake()
    {
        snake = new List<Body>();
        Body b = new Body(63, new Up());
        snake.Add(b);
        b = new Body(64, new Up());
        snake.Add(b);
        b = new Body(65, new Up());
        snake.Add(b);
        b = new Body(66, new Up());
        snake.Add(b);
    }
    public List<int> GetPositions()
    {
        List<int> positions = new List<int>();
        foreach (Body b in snake)
        {
            positions.Add(b.getPosition());
        }
        return positions;
    }
    public void Move()
    {
        Direction last = snake[0].getDirection();
        foreach(Body b in snake)
        {
            Direction ax = b.getDirection();
            b.move();
            b.SetDirection(last);
            last = ax;
        }
    }

    public void ChangeDirection(Direction direction)
    {
        snake[0].SetDirection(direction);
    }
	
}
