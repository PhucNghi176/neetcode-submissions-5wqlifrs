class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        list = {}
        for i,n in enumerate(nums):
            diff = target-n
            if diff in list:
                return [list[diff],i]
            list[n]=i
        