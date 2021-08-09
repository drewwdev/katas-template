The Collatz Conjecture states that for any natural number n, if n is even, divide it by 2. If n is odd, multiply it by 3 and add 1. If you repeat the process continuously for n, n will eventually reach 1.

Write a program that will output the length of the Collatz Conjecture for any given n. In the example above, the output would be 8.

If n % 2 = 0, divide by 2 until n = 1
Each time you divide by 2, add the outcome to a list
If n % 2 != 0, add 1 to n
Each time you divide by 2, add the outcome to a list
Divide by 2 until n = 1
Once n = 1, count the length of the list
