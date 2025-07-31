# Divide-a-String-Into-Groups-of-Size-k
Leetcode Problem #2138. Divide a String into group of size k, and return as an array of Strings.

# String Partitioning by Group Size

This function partitions a given string `s` into groups of size `k`. If the last group has fewer than `k` characters, it is padded with a given fill character to reach the required size.

## Problem Description

- The first group consists of the first `k` characters of the string.
- The second group consists of the next `k` characters, and so on.
- Each character in the string is included in exactly one group.
- If the final group has fewer than `k` characters, it is completed by appending the `fill` character.
- After removing the fill characters from the last group (if added), and concatenating all groups in order, the result should match the original string `s`.
---
