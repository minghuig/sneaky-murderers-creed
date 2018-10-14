using UnityEngine;

[System.Serializable]
public class ChessPosition {
    public int row;
    public int column;

    public ChessPosition(int row, int column) {
        this.row = row;
        this.column = column;
    }

    public ChessPosition(string position) {
        this.row = ChessPositionTranslator.GetRow(position);
        this.column = ChessPositionTranslator.GetColumn(position);
    }

    public Vector3 GetWorldPosition() {
        return Services.ChessBoardView.GetWorldPosition(this);
    }

    public override string ToString() {
        return columnDisplay + rowDisplay;
    }

    public string columnDisplay {
        get {
            return ((char) ((int) 'A') + column).ToString();
        }
    }

    public string rowDisplay {
        get {
            return (row + 1).ToString();
        }
    }
}