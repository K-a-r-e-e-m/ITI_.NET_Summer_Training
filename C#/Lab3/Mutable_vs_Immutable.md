## Mutable VS Immutable Types

Mutable and immutable are English words that mean "can change" and "cannot change" respectively. The meaning of these words is the same in C# programming language; that means the mutable types are those whose data members can be changed after the instance is created but Immutable types are those whose data members cannot be changed after the instance is created. When we change the value of mutable objects, value is changed in the same memory. But in immutable type, new memory is created and the modified value is stored in new memory.

### Mutable Types

Mean that this object can change its state after we create it.

**Examples:**
- List
- Array
- Dictionary
- StringBuilder 

### Immutable Types

Mean that this object can’t change its state after we create it. We can change the entire value but we can’t edit it or change its state.

**Examples:**
- String
- Primitive value types (int, float, double, etc.)
- Structs
- Tuples

### String

Strings are immutable, which means we are creating new memory every time instead of working on existing memory. So, whenever we are modifying a value of the existing string, i.e., we are creating a new object which refers to that modified string and the old one becomes unreferenced. Hence, if we are modifying the existing string continuously, then numbers of the unreferenced object will be increased and it will wait for the garbage collector to free the unreferenced object and our application performance will be decreased.

**Example:**

```csharp
string str = string.Empty;
for (int i = 0; i < 1000; i++)
{
    str += "Modified ";
}
```
In the code given above, string str will update 1000 times inside the loop and every time it will create a new instance so all old values will be collected by the garbage collector after some time. It is not a good approach for this solution so, it’s better to go for mutable type. So in C#, we have StringBuilder which is a mutable type. We have some advantages of immutable classes like immutable objects are simpler to construct, test, and use. Immutable objects are always thread-safe and etc.

### StringBuilder
StringBuilder is a mutable type, that means we are using the same memory location and keep on appending/modifying the content to one instance. It will not create any further instances hence it will not decrease the performance of the application.

**Example:**

```csharp
StringBuilder strB = new StringBuilder();
for (int i = 0; i < 10000; i++) 
{
    strB.Append("Modified ");
}

```
In the code given above, it has a huge impact on allocated memory because it will not create an instance each time.

We have many methods for modifying the StringBuilder string, such as:

In the code given above, it has a huge impact on allocated memory because it will not create an instance each time.

We have many methods for modifying the `StringBuilder` string, such as:

- **Append** - Appends information to the end of the current `StringBuilder`.
- **AppendFormat** - Replaces a format specifier passed in a string with formatted text.
- **Insert** - Inserts a string or object into the specified index of the current `StringBuilder`.
- **Remove** - Removes a specified number of characters from the current `StringBuilder`.
- **Replace** - Replaces a specified character at a specified index.
