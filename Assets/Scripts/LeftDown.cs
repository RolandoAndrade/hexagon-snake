public class LeftDown : Direction
{
    private int last;
    public void move(ref int pos)
    {
        last = pos % 27;
        last = last < 15 ? 13 : 14;
        pos -= last;
    }
}
