# Jagged array VS Multidimentional array

- A jagged array is an array-of-arrays, so an int[][] is an array of int[], each of which can be of different lengths and occupy their own block in memory. A multidimensional array (int[,]) is a single block of memory (essentially a matrix).


- In a multidimensional array, each element in each dimension has the same, fixed size as the other elements in that dimension. In a jagged array, which is an array of arrays, each inner array can be of a different size. By only using the space that's needed for a given array, no space is wasted. This rule, CA1814, recommends switching to a jagged array to conserve memory. 

- A Multi-dimensional array is a rectangular array in C#. It can only have a fixed number of elements in each dimension. The following code example shows us how we can declare a multi-dimensional array in C#.
```csharp
int[,] multiArray = new[3,3]
```
A jagged array is an array of arrays in C#. It can constitute arrays of different sizes in it. The following code example shows us how we can declare a jagged array in C#.
```csharp
int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int [1];
            jaggedArray[1] = new int[2];
            jaggedArray[2] = new int[3];
```
In the above code, we created the jagged array jaggedArray of size 3, which means that the jaggedArray is an array of 3 arrays. These 3 arrays are at the index 0, 1, and 2 of the jaggedArray. It is clear from the example that all these arrays are of different sizes.

The jagged arrays should be preferred over the conventional multi-dimensional arrays because of their flexibility in C#. For example, if we have to store a person’s hobbies, the preferred approach would be to use a jagged array because not everyone has the same number of hobbies. The same thing goes for interests and many other things.



**Example**

The following example shows declarations for jagged and multidimensional arrays.
```csharp
public class ArrayHolder
{
    int[][] jaggedArray = { new int[] {1,2,3,4},
                            new int[] {5,6,7},
                            new int[] {8},
                            new int[] {9}
                          };

    int[,] multiDimArray = {{1,2,3,4},
                             {5,6,7,0},
                             {8,0,0,0},
                             {9,0,0,0}
                            };
}
```
