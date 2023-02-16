namespace minesweeper;

class Cell
{
    private bool isMine = false;
    private int mineFound = 0;
    private bool cellCheck = false;
    private bool rightButtonMouse = false;

    public Cell(bool isMine = false, int mineFound = 0, bool cellCheck = false)
    {
        this.isMine = isMine;
        this.mineFound = mineFound;
        this.cellCheck = cellCheck;
    }

    public bool IsMine
    {
        get { return isMine; }
    }

    public int MineFound
    {
        get { return mineFound; }
    }
    public bool CellCheck
    {
        get { return cellCheck; }
    }
    public bool RightButtonMouse
    {
        set { rightButtonMouse = value; }
        get { return rightButtonMouse; }
    }
}
