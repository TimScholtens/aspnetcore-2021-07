# Notes


## Geschiedenis

1995 - Java

2001 - .NET

2016 - ASP.NET Core
- dependencies
- performance
- platformonafhankelijkheid

.NET + Windows + SQL Server

Visual Studio - de facto standaard development IDE

JetBrains Rider / ReSharper

WebStorm - IntelliJ

.NET Framework 4.7

ASP  (classic)
ASP.NET
- WebForms (2001) - VeCoZo
- MVC (2008)
  - 1 2 3 4 5

ASP.NET Core
- dependencies
- performance
- cross-platform
- 1 API  (bij MVC - Web API)
- Startup  (bij MVC - Global.asax)
- dependency injection

=> ninject autofac castle


.NET Core - 2016
1.0
2.0
3.0
.NET Core => .NET 5


ASP.NET Core
v1.0 - verschrikkelijk
v1.1 - verschrikkelijk
v2.0 - eerste enigszins stabiele versie
v2.1
v2.2
v3.0 - nog veel meer overgezet van het oude .NET. Geen ASP.NET WebForms of WCF. Voor WCF, zie CoreWCF van community
v5 - .NET 5


## C# en getallen

float	32 bits
double	64 bits
decimal	128 bits

## Client-side validatie

HTML5's data-*: voor custom metadata

// javascript
element.getAttribute('data-val')

jquery
jquery-validate
jquery-validate-unobtrusive

Minder relevant als je Angular, React of Vue gaat gebruiken als frontend




## Dependency injection

dependency injection == een vorm van Inversion of Control

- classes loskoppelen
- met interfaces werken
  => Data Access Layer

high cohesional, low coupling

```cs
var auto = new Auto();
auto.LeftFrontWheel = new Wheel();
auto.LeftFrontWheel = new Wheel();
auto.LeftFrontWheel = new Wheel();
auto.LeftFrontWheel = new Wheel();
```

`AddTransient()` - elke keer een nieuwe instantie - geen side effects
`AddScoped()` - per request - wel side effects
`AddSingleton()` - 1 instantie to rule them all - state

gotcha: EF Core "change tracking". Aanpassing in data bij middleware kan mee worden genomen bij een SaveChangesAsync() in controller.

## Unittesten

Unittesten is belangrijk.

- Test je code voor je naar productie gaat
- Code onderhoudbaar maken. Bij maken van aanpassingen zie je wat je kapot maakt

Test Driven Development
- eerst een test maken, daarna pas code schrijven

1. Schrijf een test
2. Run de test en zie dat hij faalt
3. Schrijf code
4. Run de test en zie dat hij slaagt
5. Refactor


omstandigheden waarin van JP niet hoeft te unittesten:

- geen logica - heel weinig logica
- als je de stagiare/tester alle tests laat schrijven
  => de developer die de feature bouwt, die hoort die details vast te leggen in unittests
- als je x% code coverage probeert te halen

```cs
public void TestIets()
{
	try
	{
		controller.Doe();
	}
	catch(Exception ex) { }
}
```

sonarqube - statische codekwaliteit - 10 DI-dingen > 7
[won't fix]

"low cohesion, high coupling"

SOLID prinpcles
Single responsiblity

### Test framework
MSTest // microsoft

// community
NUnit
xUnit


MSTest werkte niet bij .NET Core 1.0

Moq - mock framework

## Async

// PHP
mysql_query($query);

// Java
em.persist(obj);

// ADO.NET
context.SaveChanges();

## CSS units

px
- vast, hard
- meh qua a11y: houdt geen rekening met instelling van de browser

rem
- root em - relatief aan browser
- super voor a11y
- beter voorspelbaar omdat je niet met 20 levels divjes aan font-sizing rekening hoeft te houden

em
- relatief aan parent element
- super voor a11y

vw/vh
- meh qua a11y *voor font units*: zoomt niet mee


- Preprocessors: LESS, Sass, Stylus, PostCSS
- Technieken: flexible boxes, grid system, media queries, alle vele properties
	@media (min-width: 400em) {

	}
	@media (prefers-color-scheme: dark) {

	}
- CSS Battle
- Methodologies: BEM (Block-Element-Modifier), SMACSS, OOCSS
- 


## JS library kiezen

wanneer kies ik ergens voor?

- npm downloads
- GitHub stars/forks heeft het
- vragen op stackoverflow
- ervaring/kennis binnen mijn hoofd/team/organisatie
- welk bedrijf erachter zit
  => bestaan ze over x jaar nog?
  => support?
- features











