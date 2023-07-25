<h1>Peak Index in a Mountain Array</h1>
<a href="https://leetcode.com/problems/peak-index-in-a-mountain-array/">Get Task</a>

Массив arr является горным, если выполняются следующие свойства:

arr.length >= 3
Существует некоторое i с 0 < i < arr.length - 1 такое, что:
arr[0] < arr[1] < ... < arr[i - 1] < arr[i]
arr[i] > arr[i + 1] > ... > arr[arr.length - 1]
Если задан горный массив arr, вернуть индекс i, такой, что arr[0] < arr[1] < ... < arr[i - 1] < arr[i] > arr[i + 1] > ... > arr[arr.length - 1].

Необходимо решить ее за время сложности O(log(arr.length)).