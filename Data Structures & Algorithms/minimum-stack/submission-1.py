class MinStack:

    def __init__(self):
        self.stack = []

    def push(self, val: int) -> None:
        self.stack.append(val)

    def pop(self) -> None:
        self.stack.pop()

    def top(self) -> int:
        return self.stack[-1]

    def getMin(self) -> int:
        tmp = []
        m = self.stack[-1]

        while len(self.stack):
            m = min(m,self.stack[-1])
            tmp.append(self.stack.pop())
        
        while len(tmp):
            self.stack.append(tmp.pop())
        
        return m
