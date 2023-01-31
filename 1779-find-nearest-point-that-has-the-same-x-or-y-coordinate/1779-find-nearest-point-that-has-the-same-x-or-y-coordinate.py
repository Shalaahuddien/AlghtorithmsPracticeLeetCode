class Solution:
    def nearestValidPoint(self, x: int, y: int, points: List[List[int]]) -> int:
        distances =[]
        for onab in points:
            if onab[0] == x or onab[1] ==y:
                distance = abs(x-onab[0]) + abs(y-onab[1])
                distances.append(distance)
            else:
                distances.append(100000)
        mn = min(distances)
        if(mn == 100000) :
            return -1
        return distances.index(mn)