using BinhoChess.Pieces;

namespace BinhoChess;

static class ChessboardDefaults
{
    internal static IReadOnlyDictionary<(int Rank, int File), Piece> DefaultPieces { get; } = new Dictionary<(int Rank, int File), Piece>
    {
        //White pieces
        { (0,0), new Rook(new Square(0,0), eType.White) },
        { (0,7), new Rook(new Square(0,7), eType.White) },
        { (0,1), new Knight(new Square(0,1), eType.White) },
        { (0,6), new Knight(new Square(0,6), eType.White) },
        { (0,2), new Bishop(new Square(0,2), eType.White) },
        { (0,5), new Bishop(new Square(0,5), eType.White) },
        { (0,3), new Queen(new Square(0,3), eType.White) },
        { (0,4), new King(new Square(0,4), eType.White) },
        { (1,0), new Pawn(new Square(1,0), eType.White) },
        { (1,1), new Pawn(new Square(1,1), eType.White) },
        { (1,2), new Pawn(new Square(1,2), eType.White) },
        { (1,3), new Pawn(new Square(1,3), eType.White) },
        { (1,4), new Pawn(new Square(1,4), eType.White) },
        { (1,5), new Pawn(new Square(1,5), eType.White) },
        { (1,6), new Pawn(new Square(1,6), eType.White) },
        { (1,7), new Pawn(new Square(1,7), eType.White) },

        //Black pieces
        { (7,0), new Rook(new Square(7,0), eType.Black) },
        { (7,7), new Rook(new Square(7,7), eType.Black) },
        { (7,1), new Knight(new Square(7,1), eType.Black) },
        { (7,6), new Knight(new Square(7,6), eType.Black) },
        { (7,2), new Bishop(new Square(7,2), eType.Black) },
        { (7,5), new Bishop(new Square(7,5), eType.Black) },
        { (7,3), new Queen(new Square(7,3), eType.Black) },
        { (7,4), new King(new Square(7,4), eType.Black) },
        { (6,0), new Pawn(new Square(6,0), eType.Black) },
        { (6,1), new Pawn(new Square(6,1), eType.Black) },
        { (6,2), new Pawn(new Square(6,2), eType.Black) },
        { (6,3), new Pawn(new Square(6,3), eType.Black) },
        { (6,4), new Pawn(new Square(6,4), eType.Black) },
        { (6,5), new Pawn(new Square(6,5), eType.Black) },
        { (6,6), new Pawn(new Square(6,6), eType.Black) },
        { (6,7), new Pawn(new Square(6,7), eType.Black) }
    };
}