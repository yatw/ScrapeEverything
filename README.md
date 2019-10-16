
# ScrapeEverything

RESTful API that takes in a url input and return the scraped html text of the page (include the javascript rednered html that don't get parsed directly)
  
#### Ambition

This API is meant to be used by other programs, especially by [NovaTracker](https://github.com/yatw/NovaTracker)

#### How to use

Call the API directly  
```
https://localhost:44315/api/scrape?url=https%3A%2F%2Fwww.novaragnarok.com%2F%3Fmodule%3Dvending%26action%3Ditem%26id%3D7620
```

#### Technologies


-  **Language**: C#
-  **Framework**: ASP.NET
-  **Testing**: Postman
-  **Deployment**: /

#### Status

On Going


### Tasks

- [x] Set up .NET enviornment
- [x] Set up API routes
- [ ] Find a library that parse html
- [ ] Figure out how to scrap javascript html
- [ ] Return string html as API response
- [ ] Hosting 
  
 

 