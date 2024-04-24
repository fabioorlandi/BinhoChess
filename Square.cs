namespace BinhoChess;

class Square : ISquare
{
    public Square(int rank, int file)
    {
        this.Rank = rank;
        this.File = file;
    }

    public int Rank { get; }
    public int File { get; }
}

interface ISquare
{
    int Rank { get; }
    int File { get; }
}