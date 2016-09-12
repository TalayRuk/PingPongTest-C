# Ping-Pong

### By Vichitra Pool

## Description

_Using xUnit BDD. Then your goal is to use Nancy and Razor to create a website where the user enters a number into a form on the first page. When they submit the form, they should be taken to a second page printing out all the numbers from 1 to the number they entered. Except: numbers divisible by 3 should be replaced by "ping", numbers divisible by 5 should be replaced by "pong" and numbers divisible by both should be replaced by "ping-pong"._


_would need to access it http://localhost:5004 ._

## Specifications
| Behavior | Input Example | Output Example |
| ------------- |:-------------:| -----:----|
| user input number 1, result will show on the show-result page| 1 | result: 1 |
| user input number 3, result will show on the show-result page | 3 | result: 1, 2, ping |
| user input number 5, result will show on the show-result page | 5 | result: 1, 2, ping, 4, pong |
| user input number 15, , result will show on the show-result page | 15 | result: 1, 2, ping, 4, pong, ping, 7, 8, ping, pong, 11, ping, 13, 14, ping-pong



## Known Bugs

_No known Bugs_

## Tools Used

_C#, Razor, Nancy, HTML xunit.runner._
