# Razor Page Portfolio Project

## Overview
You will be creating personal portfolio to display a repository of your work that you have created while here
at Code Fellows, or external projects you are proud of. 

This is a multi-day assignmnet:

### Day 1 Milestones

Create a Razor Page Web App, You may use the "Web Application" template found in a new Visual studio web application. 

Scaffold out the beginning features of the site by doing the following:
1. Delete/remove the precreated Index, About, and Contact .cshtml files
1. Create your own `Index.cshtml` view page. This should ***not*** be a razor page with a code behind. 
	1. Don't forget about the `@page` directive at the top
1. Make your home page have 3 different links on it. Your Github Repo, A portfolio Page, LinkedIn account
1. Add a models folder and create an interface named `IPortfolioService`. Add the CRUD operation requirements to this interface that will 
be required for you to "manage" your portfolio. 
1. Create a new class in your models called `PortfolioService` that implements the above interface. 
	- Make this service implement and execute the operations with your registered database. 
1. Register your service with D.I. in your startup class. 



## ReadMe
A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.
<br />
Your job is to

1. tell them what it is (with context)
2. show them what it looks like in action
3. show them how they use it
4. tell them any other relevant details
<br />

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

<br /> <br /> Refer to the sample-README in the class repo for an example. 
- [Reference](https://github.com/noffle/art-of-readme)

## Rubric
- 7pts: Program meets all requirements described in Lab directions

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	7       | Program runs as expected, no exceptions during execution |
	5       | Program meets all of the functionality requirements described above // Program runs/compiles, Program contains logic/process errors|
	4       | Program meets most of the functionality requirements descibed above // Program runs/compiles, but throws exceptions during execution |
	3       | Program missing most of the functionality requirements descibed above // Program runs/compiles |
	2       | Missing Readme Document // Readme Document does not meet standards |
	0       | Program does not compile/run. Build Errors // Required naming conventions not met |
	0       | No Submission |

- 3pts: Code meets industry standards
	- These points are only awardable if you score at minimum a 5/7 on above criteria

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	3      | Code meets Industry Standards // methods and variables namings are appropriate // Selective and iterative statements are used appropriately, Fundamentals are propertly executed // Clearly and cleanly commented |
	2       | syntax for naming conventions are not correct (camelCasing and PascalCasing are used appropriately) // slight errors in use of fundamentals // Missing some comments |
	1       | Inappropriate naming conventions, and/or inappropriate use of fundamentals // Code is not commented  |
	0       | No Submission or incomplete submission |

