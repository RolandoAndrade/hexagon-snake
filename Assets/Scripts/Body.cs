using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body
{
    private int position;

    private Direction direction;

    public Body(int position, Direction direction)
    {
        this.position = position;
        this.direction = direction;
    }

    public void move()
    {
        direction.move(ref position);
    }

    public int getPosition()
    {
        return position;
    }
    public Direction getDirection()
    {
        return direction;
    }
    public void setPosition(int pos)
    {
        position = pos;
    }
    public void SetDirection(Direction dir)
    {
        direction = dir;
    }
}
