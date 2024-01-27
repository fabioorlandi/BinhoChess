using BinhoChess.Pieces.Interfaces;

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
    public IPiece? Piece { get; set; }
}

interface ISquare
{
    int Rank { get; }
    int File { get; }
    IPiece? Piece { get; }
}