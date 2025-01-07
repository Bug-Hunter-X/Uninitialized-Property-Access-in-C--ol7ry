# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing an uninitialized property of a class.  This often leads to a `NullReferenceException` at runtime.

## Bug Description
The `bug.cs` file contains a class with a property `MyProperty` that is not initialized. The `MyMethod` attempts to use this property in a calculation before it has been assigned a value. This results in a `NullReferenceException` when `MyMethod` is called.

## Solution
The `bugSolution.cs` file demonstrates how to fix this issue by initializing `MyProperty` before using it.  The solution ensures that `MyProperty` has a default value or is assigned a value before being accessed, preventing the exception.

## How to Reproduce
1. Clone the repository.
2. Compile and run `bug.cs` (expect a `NullReferenceException`).
3. Compile and run `bugSolution.cs` (expect no exception).