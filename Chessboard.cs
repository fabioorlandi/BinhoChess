
using BinhoChess.Pieces;

namespace BinhoChess;

public class Chessboard
{
    private readonly IEnumerable<ISquare> _squares;
    private readonly IEnumerable<Piece> _whitePieces;
    private readonly IEnumerable<Piece> _blackPieces;

    private static Chessboard? _board;
    public static Chessboard GetChessboard()
    {
        if (_board is null)
            _board = new Chessboard();

        return _board;
    }

    public static void Reset() => _board = null;

    public static void Start() { }

    private Chessboard()
    {
        _whitePieces = this.BuildWhitePieces();
        _blackPieces = this.BuildBlackPieces();

        _squares = this.BuildSquares();
    }

    private IEnumerable<ISquare> BuildSquares()
    {
        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 8; j++)
                yield return new Square(rank: i, file: j);
    }

    private IEnumerable<Piece> BuildWhitePieces()
    {
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 8; j++)
                if (ChessboardDefaults.DefaultPieces.TryGetValue((i, j), out var piece))
                    yield return piece;
    }

    private IEnumerable<Piece> BuildBlackPieces()
    {
        for (int i = 6; i < 8; i++)
            for (int j = 0; j < 8; j++)
                if (ChessboardDefaults.DefaultPieces.TryGetValue((i, j), out var piece))
                    yield return piece;
    }
}