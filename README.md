# RabbitMQclient
I developed a windows app in C# .Net 6 that can be used for testing rabbitmq based apps, this client app will helps you to publish/consume payloads without login to the rabbitmq admin page.


## Prerequesties
Installation and setup
```
Setting up RabbitMQ is quite simple, download and install RabbitMQ server.
https://www.rabbitmq.com/download.html
```

Create Exchanges,Queues and Bindings
```
Generally, when we publish a message to rabbitmq that will not directly send to queue, instead first the message will be send to 
exchanges, then after that a routing agent reads and sends it to the appropriate queue with help of header attributes, 
bindings and routing keys.

So, before we proceed first we need to create exchange, queue and need to bind queue to exchange. We can create exchanges, 
queues and bindings either directly from rabbitmq web management portal.
```
## Requirements

* Visualstudio 2022
* .NET Core 6

Add RabbitMQ.Client NuGet Package
```
Create a new c# windows appliction, we need to add “RabbitMQ.Client” nuget package in our application to communicate with 
RabbitMQ server to publish or consume messages for that, right click on your application and select Manage NuGet Packages, 
Now search for RabbitMQ.Client package and install it in your application 
```
## Run the app

Publish
```
Download the project and run
Configure rabbitmq Exchanges,Queues details in UI
Enter your payload to send
Publish it
Check the published message status in activity logs
```
Consume

```
Download the project and run
Configure rabbitmq Exchanges,Queues details in UI
Click Consume, this will continiously started listen 
If any new messages will be updated in activity logs
```
<img width="830" alt="image" src="https://user-images.githubusercontent.com/82328342/201350642-d96feebe-a1ec-4ea0-97e1-6a6ee0bdc4a7.png">
