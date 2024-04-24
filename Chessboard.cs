
using BinhoChess.Pieces;
using BinhoChess.Pieces.Interfaces;

namespace BinhoChess;

public class Chessboard
{
    private readonly IEnumerable<ISquare> _squares;
    private readonly IEnumerable<IPiece> _whitePieces;
    private readonly IEnumerable<IPiece> _blackPieces;

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
        _squares = this.BuildSquares();

        _whitePieces = this.BuildWhitePieces();
        _blackPieces = this.BuildBlackPieces();
    }

    private IEnumerable<ISquare> BuildSquares()
    {
        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 8; j++)
                yield return new Square(rank: i, file: j, assignDefaultPiece: true);
    }

    private IEnumerable<IPiece> BuildWhitePieces()
    {
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 8; j++)
            {
                var piece = this.GetPiece(i, j);

                if (piece is not null)
                    yield return piece;
            }
    }

    private IEnumerable<IPiece> BuildBlackPieces()
    {
        for (int i = 6; i < 8; i++)
            for (int j = 0; j < 8; j++)
            {
                var piece = this.GetPiece(i, j);

                if (piece is not null)
                    yield return piece;
            }
    }

    private IPiece? GetPiece(int rank, int file) =>
        _squares.FirstOrDefault(S => S.Rank == rank && S.File == file)?.Piece;
}