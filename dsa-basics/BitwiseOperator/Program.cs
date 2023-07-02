/*
  Bit Manipulations: 
 Operators:
    1. AND 

    A  |  B   | A & B
    0  |  0   |  0
    0  |  1   |  0
    1  |  0   |  0
    1  |  1   |  1

Notes: When you & with any number, digits remains the same

    2. OR : If any one is true, entire expression is true

    A  |  B   | A | B
    0  |  0   |  0
    0  |  1   |  1
    1  |  0   |  1
    1  |  1   |  1

    3. XOR : if and only if : only one should be true

    A  |  B   | A ^ B
    0  |  0   |  0
    0  |  1   |  1
    1  |  0   |  1
    1  |  1   |  0

Notes: 
1. A^1 = C(A) -> Complement of A
2. A^A = 0
3. A^0 = A

    4. Complement (~)
     A | ~A
     0 | 1
     1 | 0 
    
 
 */

Console.WriteLine(long.MaxValue);