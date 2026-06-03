class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        if len(tokens)==1 :
            return int(tokens[0])
        stack =[]
        op = {"+","-","*","/"}
        for c in tokens:
            if c not in op:
                stack.append(c)
            else:
                tmp2=int(stack.pop())
                tmp1=int(stack.pop())
                match c:
                    case "+":
                        stack.append(tmp1+tmp2)
                    case "-":
                        stack.append(tmp1-tmp2)
                    case "*":
                        stack.append(tmp1*tmp2)
                    case "/":
                        stack.append(int(tmp1/tmp2))
        

        return stack.pop()

            
            

        