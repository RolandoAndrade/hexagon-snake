public class RightDown : Direction
{
    private int last;
    public void move(ref int pos)
    {
        
        last = pos % 27;
        last = last < 15 ? 15 : 14;
        pos += last;
        if (pos % 14 == 0)
            throw new System.Exception();
        
    }
}
