class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        cols = defaultdict(set)
        rows = defaultdict(set)
        squares = defaultdict(set)

        for r in range(9):
            for c in range(9):
                tmp = board[r][c]
                if tmp == '.' :
                    continue
                if (tmp in cols[c] or tmp in rows[r] or tmp in squares[r//3,c//3]):
                    return False
                
                cols[c].add(tmp)
                rows[r].add(tmp)
                squares[(r//3,c//3)].add(tmp)

        return True
        