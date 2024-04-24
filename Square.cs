using BinhoChess.Pieces;
using BinhoChess.Pieces.Interfaces;

namespace BinhoChess;

class Square : ISquare
{
    public Square(int rank, int file)
        : this(rank, file, false)
    { }

    public Square(int rank, int file, bool assignDefaultPiece)
    {
        this.Rank = rank;
        this.File = file;

        if (assignDefaultPiece)
            this.Piece = this.AssignDefaultPiece(rank, file);
    }

    public int Rank { get; }
    public int File { get; }
    public IPiece? Piece { get; set; }

    private IPiece? AssignDefaultPiece(int rank, int file)
    {
        if (SquareDefaults.PiecesDefaultSquares.TryGetValue((rank, file), out var type))
            return type switch
            {
                _ when type == typeof(Bishop) => new Bishop(),
                _ when type == typeof(King) => new King(),
                _ when type == typeof(Knight) => new Knight(),
                _ when type == typeof(Pawn) => new Pawn(),
                _ when type == typeof(Queen) => new Queen(),
                _ when type == typeof(Rook) => new Rook(),
                _ => null
            };

        return null;
    }
}

interface ISquare
{
    int Rank { get; }
    int File { get; }
    IPiece? Piece { get; }
}