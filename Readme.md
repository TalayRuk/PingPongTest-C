# Ping-Pong

### By Vichitra Pool

## Description

_Using xUnit BDD. Then your goal is to use Nancy and Razor to create a website where the user enters a number into a form on the first page. When they submit the form, they should be taken to a second page printing out all the numbers from 1 to the number they entered. Except: numbers divisible by 3 should be replaced by "ping", numbers divisible by 5 should be replaced by "pong" and numbers divisible by both should be replaced by "ping-pong"._


_would need to access it http://localhost:5004 ._

## Specifications
| Behavior | Input Example | Output Example |
| ------------- |:-------------:| -----:----|
| user input number| 1 | result: 1 |
| user input number| 3 | result: ping |
| user input number| 5 | result: pong |
| user input number | 15 | result: ping-pong
|user input number | 3 |result: ping, 2, 1


## Known Bugs

_No known Bugs_

## Tools Used

_C#, Razor, Nancy, HTML xunit.runner._
