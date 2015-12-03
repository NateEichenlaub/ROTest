##Sample project to illustrate issues with Restful Objects Server

Domain model contains simple test classes with properties consisting of randomly generated numbers and charater strings.

Seed method on DbInitializer should populate database with 1000 test objects.

ROServerTest project is a standalone Restful Objects Server with a simple AngularJS homepage to send GET requests for TestObject instances over the restful objects API using angular's $http service.
Radio buttons allow selection of either random objects or a specific domain object by id. The "random" option will use a different randomly generated id for each request.

###My Observations:
- Errors occur less frequently with this simple domain model than with more complex domain models
- Requests in blocks of 1000 seem to work best to illustrate the problem
- Errors are unpredictable - on some occasions thousands of requests can be sent without a single error, on other occasions errors occur much more frequently
- Some requests get stuck in the "pending" state for long periods of time
- Idle CPU usage on server increases as more requests are sent. After several thousand requests CPU usage reaches nearly 100% and seems to stay at that level until the application is restarted
