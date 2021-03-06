# Angular 2 ASP.NetCore Multi-SPA framework

SPA or SinglePage Application frameworks provide users a great experience, pages feel responsive, but these often use 'flat' HTML client-side templates.
And if using forms, from simple labels + text boxes through to date pickers, you still repeat large parts of your HTML and javascript validation code.

This framework uses ASP.Net MVC to generate the HTML templates, this allows you use of ASP.Net Tag Helpers and Razor syntax, C# backend code as well as your own Custom Tag Helpers.

By creating tags using Custom Tag Helpers you minimizing what needs to be used on the page itself, as much HTML, CSS and script will be injected as possible using conventions or attributes.

In addition to the ASP.Net Core backend, the front end uses Angular 2 and Bootstrap 4.0.

For further background details, see the Github Wiki here: https://github.com/RobertDyball/Angular2MultiSPA/wiki
or follow the blog posts here: http://dyball.wordpress.com

Note: this is open source, if something doesn't work, someone will try and help if they can,but if you want support, get in and be a part of this project.

The project is purposely not opinionated about the data layer; if you wantto use EFnative methods, CQRS, or someother data layer- that's up to you.

Similarly, while the project is currently using OpenIdDict, it is not forcing you into this, you can use another authorisation/authentication framwork (or none at all) if you wish.

#### Prerequisites

Download and install latest ASP.Net Core to suit your platform, see ASP.Net Core downloads here: http://asp.net 
  ( currently latest version is 1.0.0-preview2-003133 )

If using Windows, use Visual Studio 2015 Update 3, with ASP.Net core tooling updates, 
or alternately use Visual Studio code.

Node.js and npm are essential to Angular 2 development and used by Visual Studio. 

Install Typescript and Typings globally, as these will be used by the application.

npm install -g typescript
npm install -g typings 
  

#### Running

Pull a copy of the repo, load the solution into Visual Studio, build (which will restore dependencies), and hit F5 or ctrl-F5

Dependencies can be installed manually, using the command:

dotnet restore

this command will also automatically install any outstanding NPM packages, saving you the need of typing

npm install
npm install --save-dev

If you have any issues, try running both of these commands, in an admin command prompt, and look for any error messages.

So after you build and run, browse to: http://localhost:7010/ to see the Angular 2 using an ASP.Net partial page, with CSHTML running razor into the Angular template.

#### Want to help? 

There's still a few data types which need to be handled, for data display and data input. Send me a message email is my firstname dot lastname (see the github repo name) at gmail.com, I'll add you as a collaborator.
