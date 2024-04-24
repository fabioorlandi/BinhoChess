namespace BinhoChess;

class TurnManager
{
    private eType? _currentTurn;

    private static TurnManager? _turnManager;
    public static TurnManager GetTurnManager()
    {
        if (_turnManager is null)
            _turnManager = new TurnManager();

        return _turnManager;
    }

    private TurnManager() { }

    public eType CurrentTurn() => _currentTurn ?? eType.White;

    public eType RequestTurn()
    {
        _currentTurn = _currentTurn == eType.White ? eType.Black : eType.White;

        return this.CurrentTurn();
    }
}