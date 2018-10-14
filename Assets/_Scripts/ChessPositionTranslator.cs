public static class ChessPositionTranslator {
    public static ChessPosition GetChessPosition(string position) {
        int column = ChessPositionTranslator._GetColumn(position[0]);
        int row = ChessPositionTranslator._GetRow(position[1]);
        return new ChessPosition(row, column);
    }

    public static int GetRow(string position) {
        return ChessPositionTranslator._GetRow(position[1]);
    }

    public static int GetColumn(string position) {
        return ChessPositionTranslator._GetColumn(position[0]);
    }

    private static int _GetColumn(char columnString) {
        switch (columnString) {
            case 'A': return 0;
            case 'B': return 1;
            case 'C': return 2;
            case 'D': return 3;
            case 'E': return 4;
            case 'F': return 5;
            case 'G': return 6;
            case 'H': return 7;
            default: throw new System.Exception();
        }
    }

    private static int _GetRow(char rowString) {
        switch (rowString) {
            case '1': return 0;
            case '2': return 1;
            case '3': return 2;
            case '4': return 3;
            case '5': return 4;
            case '6': return 5;
            case '7': return 6;
            case '8': return 7;
            default: throw new System.Exception();
        }
    }
}