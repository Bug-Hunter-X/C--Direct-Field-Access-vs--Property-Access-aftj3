# C# Direct Field Access vs. Property Access

This repository demonstrates a common, yet subtle, potential issue in C# related to how fields are accessed within a class. Directly accessing fields instead of using properties can bypass crucial logic within the property's setter, leading to unexpected program behavior and potential bugs.  This example highlights best practices for encapsulation and maintaining data integrity.

**Key Concept:**

Encapsulation is a fundamental principle in object-oriented programming that aims to protect internal data by controlling access. Properties provide a controlled way to access and modify fields, allowing you to incorporate validation, calculations, or other logic during the setting process.

**Example:**

The provided `bug.cs` shows a simple class with a field and a property. The example shows both direct field access and property access, highlighting the potential for errors if direct field access is used improperly.

**Solution:**

The `bugSolution.cs` file doesn't directly change the code because the core concept focuses on correct coding practices (using Properties).  However, it offers an improved version showing better usage of the property.