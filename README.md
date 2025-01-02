#H1 AI-Powered BogoSort
## They're calling it "The Most Efficient Sorting Algorithm Ever"

Simply import the class library into your project with
using AIBogosort.AIBogo

then create a new AIBogo, passing in your ChatGPT API Key.

Then pass your list of integers into AIBogo.AISortInts(List<Int>);

And receive a sorted list of integers maybe never!

###Under The Hood
AI Bogo takes the guesswork of sorting a list of integers and passes it onto ChatGPT.
We feed it a friendly greeting, followed by an instruction to sort the list of integers at random, then we give it the list in plain text!
We receive its response in convenient plain text, and convert it to a list of integers.
We then check to see if the list is sorted. Any hallucinations will be conveniently filtered out, as the list is checked against the initial list to ensure that it contains only those numbers initially present and is of the same size.

Never use this (or do, im not paying to test it)
