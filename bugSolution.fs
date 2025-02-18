The behavior is explained by how the F# compiler handles inline functions.  Inline functions are expanded at the call site.  When `addInline` is called the first time, the values of `x` and `y` are substituted directly into the expression `x + y`.  Subsequent changes to `x` and `y` don't affect this initial substitution.

To get the expected behavior with inline functions, you should avoid mutable variables entirely.  Use immutable values and consider refactoring your code to use more functional techniques:

```fsharp
let x = 10
let y = 20

let add x y = x + y

let inline addInline x y = x + y

let result1 = add x y
let result2 = addInline x y

printfn "%d %d" result1 result2

let x2 = 30
let y2 = 40

let result3 = add x2 y2
let result4 = addInline x2 y2

printfn "%d %d" result3 result4
```
This revised code uses immutable variables, ensuring consistent behavior between the regular and inline functions.