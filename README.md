# The Assignment of MVC

For this assignment, you are to create an MVC Web Application from scratch.
Use the ASP.NET Core Web Application solution/project type, and the “Empty” template to start
with.
This will give you the basic structure to build your project from.
Required Features:
•
•
•
General folder/file structure of a MVC project.
A Layout file for your views to use. It should contain:
o A header element, containing a page logo and a navigation menu
o A container to be filled with each view.
o A footer, containing the current date using Razor, and your name.
A controller with at least three views.
o About – Containing information about yourself (CV, for example).
o Contact – Containing your contact information (Use fake info if you want).
o Projects – Containing the GitHub links to your assignments you have finished with
a small description about them.

Create new Controller named Doctor to the existing MVC-project and inside it make a View that
takes a temperature in number form, checks how high it is, and tells you whether you have a
fever or not.
Required Features:
•
•
•
A form that takes a single numeric value (float or integer) and sends it on to a controller
action.
The value should be interpreted as a temperature, and checked against the thresholds
for fever.
A message should appear on the page, showing whether you have a fever or not.
Optional:
•
•
Add a check for hypothermia as well as fever, and display that as a message if you have a too low
temperature.
Add radio buttons to allow switching between Fahrenheit and Celsius degrees.
Code Requirements:
•
•
•
•
•
•
The view must have a form that sends the value into the action.
If the value is not set, the page should not get a message to display, otherwise it should
evaluate it and send back the message.
A custom route must be defined for this view.
The view must be from an Action inside Doctor controller.
The code checking the temperature and giving the diagnose text back must be in a utility
class with a static method, contained in Models folder.
Define a custom route to reach the fever check “/FeverCheck”, rather than having to
specify a controller and action

Add a new view containing a number-guessing game.
The page should include a form that allows you to input a number. When the page is loaded for
the first time, the controller should generate a random number between 1 and 100, that it will
save in a session so it remembers it for the page even if it is refreshed.
When you submit a number from the Form, it should compare your number to the one the
controller generated. If it is the correct one, you should get a message congratulating you on
your success, and a new number should be generated.
Otherwise, it should tell you whether your guess is either too high or too low, and let you take
another guess.
Required Features:
•
•
•
A randomly generated number, hidden from the user of the page.
The ability to guess, through a form, which number was generated.
A message displaying how well you did.
