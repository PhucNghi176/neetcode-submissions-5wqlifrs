class Solution:
    def dailyTemperatures(self, tm: List[int]) -> List[int]:
        res = [0] * len(tm)
        for i in range(len(tm)):
            c = 0
            for j in range(i + 1, len(tm)):
                if tm[i] < tm[j]:
                    c += 1
                    res[i]=c
                    break
                else:
                    c+=1

        return res
