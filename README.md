# F# Mutability and Inline Functions: Unexpected Behavior

This example demonstrates a subtle difference between regular functions and inline functions in F# when dealing with mutable variables.

## Bug Description
The `add` function (non-inline) correctly reflects the changes made to mutable variables `x` and `y`. However, the `addInline` function (inline) does not update with the changes, it seems to capture the initial values.