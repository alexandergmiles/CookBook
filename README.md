# CookBook
### Cookbook - Bringing cookbooks into the 21st century
Anyone can whip up a dish in the kitchen these days. Anyone with enough dedication, gusto, and a little bit of luck can become the next internet sensation. CookBook enables people from your 10 year old sharing their cookie recipe to your 85 year old grandmother sharing some family secrets with the internet. All while getting paid for doing it.

#### How it works? 
Anyone can get started with CookBook. Simply load up the app and get working! To share a recipe, you'll need a user account, choosing either one of ours or one of your social media apps. For a recipe, you'll need your ingredient and the weight or volume of the ingredient. For each step, you'll take a snippet of the method, showing clearly how you managed to get those perfect stiff peaks. With each step, you can leave a quick bit of text to explain the method you've used alongside your short clip.
#### The exciting stuff: Technology
##### Our backend
To make our platform work we use C# to power our API. To speak to our database we use Dapper as our adorable Mikro-ORM to make sure we aren't writing too much unwieldy SQL. Speaking of SQL, we use Postgresql to store everything, so no trying to sneak anything. When you think about it, our stack is pretty simple:

        App <-> [ Web API <-> Dapper <-> Postgresql ]
 *Where [ ] defines our AWS boundaries.*

It's all good and well saying "We run on AWS" but what does that really mean for CookBook? We want to make sure that our content gets to our users quickly and reliably. To ensure that, we make use of containers to provide the scale we need, leveraging the power of Docker containers and .Net Core. 

Looking back at the previous diagram we can see it as:

         API Gateway <-> AWS ECS | CloudFront <-> RDS    
         
By using the API Gateway to balance our load we can ensure the user connects to the best geographically suitable endpoint for them, while considering the load it might be facing. The API Gateway will point to the best instance of the ECS, or the cache, depending on what the user is trying to get. If they need to go a step further to the database, that's handled in the AWS magic. 

 #### Frontend
 While we will have our iOS app, we also need a web app, as not everyone has an iOS device. To get the website built, we use Typescript and Angular to create the frontend, because who doesn't a bit of modular components for reuse. 

