
using BinhoChess.Pieces;
using BinhoChess.Pieces.Interfaces;

namespace BinhoChess;

public class Chessboard
{
    private IEnumerable<ISquare> _squares;
    private IEnumerable<IPiece> _whitePieces;
    private IEnumerable<IPiece> _blackPieces;

    private static Chessboard? _board;
    public static Chessboard GetChessboard()
    {
        if (_board is null)
            _board = new Chessboard();

        return _board;
    }

    public static void Reset() => _board = null;

    private Chessboard()
    {
        _whitePieces = this.BuildPieces();
        _blackPieces = this.BuildPieces();
        _squares = this.BuildSquares();

        this.AssignWhitePieces();
        this.AssignBlackPieces();
    }

    private IEnumerable<ISquare> BuildSquares()
    {
        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 8; j++)
                yield return new Square(i, j);
    }

    private IEnumerable<IPiece> BuildPieces()
    {
        for (int i = 0; i < 8; i++)
            yield return new Pawn();

        for (int i = 0; i < 2; i++)
        {
            yield return new Knight();
            yield return new Bishop();
            yield return new Rook();
        }

        yield return new Queen();
        yield return new King();
    }

    private void AssignWhitePieces()
    {
        throw new NotImplementedException();
    }

    private void AssignBlackPieces()
    {
        throw new NotImplementedException();
    }
}