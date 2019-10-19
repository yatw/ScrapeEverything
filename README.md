

# ScrapeEverything

RESTful API that takes in an url input and return the scraped html text of the page (include the JavaScript rendered html that don't get parsed directly)

## About the project

#### Ambition

There are many third party libraries that scrape html data of a website, but most are incapable of scraping JavaScript dynamically generated content.  
This API is meant to solve this problem and simplify the process to "given a url return html as string"


#### Technologies

-  **Language**: C#
-  **Framework**: ASP.NET
-  **Web Scraping**: Selenium PhantomJS
-  **Testing**: Postman
-  **Deployment**: /

#### Status

On Going


#### Tasks

- [x] Set up .NET enviornment
- [x] Set up API routes
- [x] Scrape JavaScript html
- [x] Provide basic login
- [ ] Hosting 

## How to use

API URL is ```https://localhost:44315/api/scrape```

### Get Request: 
Takes in url parameter (remember to encode the url )  
Sample
```
https://localhost:44315/api/scrape?url=https%3A%2F%2Fwww.novaragnarok.com%2F%3Fmodule%3Dvending%26action%3Ditem%26id%3D7620
```


### Post Request:
Takes in url and login information  
Scraper will attempt to find the input fields by Id and click the login button by value  
Sample request body in JSON
```
{
	"url":"https://www.novaragnarok.com/?module=vending&action=item&id=21047",
	"requireLogin": true,
	"userNameFieldId": "login_username",
	"userName": "sampleName",
	"userPasswordFieldId": "login_password",
	"userPassword": "samplePassword",
	"btnValue": "Log In"
}
```
### Response

Sample response in JSON
```
{
    "codeTable": {
        "0": "Error: Missing information",
        "1": "Success",
        "2": "Error: Invalid Url",
        "3": "Error: Cannot Find Login Fields"
    },
    "code": 1,
    "message": "Success",
    "html": "<html>...</html>"
}
```

## Dependencies

In Visual Studio, install the following NuGet Packets
```
https://www.nuget.org/packages/Selenium.WebDriver
https://www.nuget.org/packages/phantomjs.exe/
```