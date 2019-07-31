# Problem
Problem source: https://leetcode.com/problems/container-with-most-water/

Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai). n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). Find two lines, which together with x-axis forms a container, such that the container contains the most water.

# Solution
Using two indexes that point to the start and end of an array, program compares values. Current size is a minimum value of left or right side multiplied by the length betweed sides:

```
Min(left, right) * (rightI - leftI)
```


Then, I store max size in a variable and assign a new value if current size is bigger than max size

```
maxSize = Max(size, maxSize)
```


After that, program increments one of the pointers in order to find other sizes. To find bigger size program changes pointer with the lowest height

```
if(left < right)
    leftI++;
else
    rightI--;
```

Do it until pointers will meet each other, which means that program has checked whole array

```
while(rightI > leftI)
```

# Complexity
## Time Complexity - O(n)
Program goes through the array single time

## Memory Complexity -  O(1)
There is a constant amount of helper variables and it doesn't depend on input array length