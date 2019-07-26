# NumberTranslator

### Intern Interview Question

One of our interns was asked this as part of a Software Engineering interview and I thought I would give it a lash. 
The project comes with tests for numbers up to three digits with the caveat you may be asked to extend for more during the interview.

The exercise highlights the candidates ability to work with loops, conditional logic and edge case input. 

## Caveats and Observations
1. Converting a single digit number is fairly straight forward and should be the first thing you should try and do;
1. Double-digit conversion should build on the first translation of a single digit number, but also account for zeros. You cannot covert 22 to "TWO TWO", but "TWENTY TWO". "20" is TWENTY, not "TWO ZERO";
1. Additionally 3-digit numbers, such as 103, cannot be converted to "ONE ZERO THREE", but "ONE HUNDRED AND THREE";
1. Expect most decisions to be made around the zero handling;
1. Normally, "IF" statements should not be longer than 3 conditions initially and you should look to refactor using a SWITCH statement or a modular approach;
1. In this instance I have chosen to use two dictionaries to store the lookup. In my opinion this is cleaner than multi-dimensional arrays or static lists.

Some NUNIT tests have been included with some examples.

Why not try adding support for four digit numbers.