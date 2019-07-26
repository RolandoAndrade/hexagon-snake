public class RightUp: Direction
{
    private int last;
    public void move(ref int pos)
    {
        
        last = pos % 27;
        last = last <15 ? 14 : 13;
        pos += last;
    }
}
