using BinhoChess.Pieces;

namespace BinhoChess;

static class SquareDefaults
{
    internal static IReadOnlyDictionary<(int Rank, int File), Type> PiecesDefaultSquares { get; } = new Dictionary<(int Rank, int File), Type>
    {
        { (0,0), typeof(Rook) },
        { (0,7), typeof(Rook) },
        { (7,0), typeof(Rook) },
        { (7,7), typeof(Rook) },

        { (0,1), typeof(Knight) },
        { (0,6), typeof(Knight) },
        { (7,1), typeof(Knight) },
        { (7,6), typeof(Knight) },

        { (0,2), typeof(Bishop) },
        { (0,5), typeof(Bishop) },
        { (7,2), typeof(Bishop) },
        { (7,5), typeof(Bishop) },

        { (0,3), typeof(Queen) },
        { (7,3), typeof(Queen) },

        { (0,4), typeof(King) },
        { (7,4), typeof(King) },

        { (1,0), typeof(Pawn) },
        { (1,1), typeof(Pawn) },
        { (1,2), typeof(Pawn) },
        { (1,3), typeof(Pawn) },
        { (1,4), typeof(Pawn) },
        { (1,5), typeof(Pawn) },
        { (1,6), typeof(Pawn) },
        { (1,7), typeof(Pawn) },
        { (6,0), typeof(Pawn) },
        { (6,1), typeof(Pawn) },
        { (6,2), typeof(Pawn) },
        { (6,3), typeof(Pawn) },
        { (6,4), typeof(Pawn) },
        { (6,5), typeof(Pawn) },
        { (6,6), typeof(Pawn) },
        { (6,7), typeof(Pawn) }
    };
}